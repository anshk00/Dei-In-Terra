using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;

using System.Diagnostics;

namespace DeiInTerra
{
    class MenuScreen : GameScreen
    {
        private Texture2D menuScreen;
        private Button newGame, loadGame, options, credits, exit;
        private Vector2 size, origin, heightModifier;
        private SpriteFont menuFont;
        private List<Button> buttonList = new List<Button>();
        private GameScreen nextScreen;
        public override void LoadContent()
        {
            base.LoadContent();
            menuScreen = content.Load<Texture2D>("MenuScreen/MenuScreen");
            menuFont = content.Load<SpriteFont>("MenuScreen/MenuFont");
            CreateButtons();

        }

        public override void UnloadContent()
        {
            base.UnloadContent();
        }

        public override void Update(GameTime gameTime)
        {
            CheckMenuClicks();
            base.Update(gameTime);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            
            spriteBatch.Draw(menuScreen, Vector2.Zero, Color.White);
            DrawButtons(spriteBatch);

            base.Draw(spriteBatch);
        }

        public void CreateButtons()
        {
            origin = new Vector2(283f, 130f);
            size = new Vector2(259f, 40f);
            heightModifier = new Vector2(0f, 80f);

            newGame = new Button(origin, size, "New Game");
            origin = Vector2.Add(origin, heightModifier);
            buttonList.Add(newGame);

            loadGame = new Button(origin, size, "Load Game");
            origin = Vector2.Add(origin, heightModifier);
            buttonList.Add(loadGame);

            options = new Button(origin, size, "Options");
            origin = Vector2.Add(origin, heightModifier);
            buttonList.Add(options);

            credits = new Button(origin, size, "Credits");
            origin = Vector2.Add(origin, heightModifier);
            buttonList.Add(credits);

            exit = new Button(origin, size, "Exit");
            buttonList.Add(exit);

        }
        public void DrawButtons(SpriteBatch spriteBatch)
        {
            foreach(var button in buttonList)
            {
                Vector2 stringLength = menuFont.MeasureString(button.buttonLabel);
                stringLength = Vector2.Divide(stringLength, 2f);
                Vector2 stringBase = Vector2.Subtract(button.stringOrigin, stringLength);
                spriteBatch.DrawString(menuFont, button.buttonLabel, stringBase, Color.White);
            }
        }

        public void CheckMenuClicks()
        {
            if (InputManager.Instance.CheckCursorLocation(newGame.dimensions) &&
                InputManager.Instance.LeftButtonDown())
            {
                Debug.WriteLine("New Game");
                nextScreen = new GameplayScreen();
            }

            else if (InputManager.Instance.CheckCursorLocation(loadGame.dimensions) &&
                InputManager.Instance.LeftButtonDown())
            {
                Debug.WriteLine("Load Game");
            }

            else if (InputManager.Instance.CheckCursorLocation(options.dimensions) &&
                InputManager.Instance.LeftButtonDown())
            {
                Debug.WriteLine("Options");
            }

            else if (InputManager.Instance.CheckCursorLocation(credits.dimensions) &&
                InputManager.Instance.LeftButtonDown())
            {
                Debug.WriteLine("Credits");
            }

            else if (InputManager.Instance.CheckCursorLocation(exit.dimensions) &&
                InputManager.Instance.LeftButtonDown())
            {
                Debug.WriteLine("Exit");
            }
            if(nextScreen!= null)
                ScreenManager.Instance.changeScreens(nextScreen);
        }

    }
}

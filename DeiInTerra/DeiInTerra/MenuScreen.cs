using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;

namespace DeiInTerra
{
    class MenuScreen : GameScreen
    {
        private Texture2D menuScreen;
        private DeiInTerra.Button newGame, loadGame, options, credits, exit;
        public override void LoadContent()
        {
            base.LoadContent();
            menuScreen = content.Load<Texture2D>("MenuScreen/MenuScreen");
        }

        public override void UnloadContent()
        {
            base.UnloadContent();
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
            spriteBatch.Draw(menuScreen, Vector2.Zero, Color.White);
        }

    }
}

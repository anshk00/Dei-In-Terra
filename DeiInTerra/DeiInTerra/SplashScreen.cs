using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace DeiInTerra
{
    public class SplashScreen : GameScreen
    {
        private Texture2D celestialSoft, cognitiveThought;
        private float delay = 3, currentElapsedTime, endDelay = 3;
        private bool drawPublisherScreen = false, endSplashScreenTimer = false;

        private GameScreen nextScreen;

        public override void LoadContent()
        {
            base.LoadContent();
            celestialSoft = content.Load<Texture2D>("SplashScreen/CelestialSoft");
            cognitiveThought = content.Load<Texture2D>("SplashScreen/CognitiveThought");
            nextScreen = new MenuScreen();
        }

        public override void UnloadContent()
        {
            base.UnloadContent();
        }

        public override void Update(GameTime gameTime)
        {
            currentElapsedTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
            delay -= currentElapsedTime;
            if (currentElapsedTime >= delay)
            {
                drawPublisherScreen = true;
                endSplashScreenTimer = true;
            }
            if (endSplashScreenTimer)
                endDelay -= currentElapsedTime;
            if (currentElapsedTime >= endDelay || InputManager.Instance.KeyPressed(Keys.Enter))
                ScreenManager.Instance.changeScreens(nextScreen);
            base.Update(gameTime);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(celestialSoft, Vector2.Zero, Color.White);
            if (drawPublisherScreen)
            {
                spriteBatch.Draw(cognitiveThought, Vector2.Zero, Color.White);
            }
        }
    }
}
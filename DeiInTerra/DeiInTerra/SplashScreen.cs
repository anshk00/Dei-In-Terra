using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace DeiInTerra
{
    public class SplashScreen : GameScreen
    {
        private Texture2D celestialSoft, cognitiveThought;
        private float delay = 5, currentElapsedTime;
        private bool drawPublisherScreen = false;

        public override void LoadContent()
        {
            base.LoadContent();
            celestialSoft = content.Load<Texture2D>("SplashScreen/CelestialSoft");
            cognitiveThought = content.Load<Texture2D>("SplashScreen/CognitiveThought");
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
                drawPublisherScreen = true;
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Xml.Serialization;
using Microsoft.Xna.Framework.Input;

namespace DeiInTerra
{

    public class SplashScreen : GameScreen
    {
        Texture2D celestialSoft, cognitiveThought;
        private float delay = 15, currentElapsedTime;
        private boolean drawPublisherScreen = false;
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
            currentElapsedTime = (float) gameTime.ElapsedGameTime.TotalSeconds;
            if (currentElapsedTime>delay)
                drawPublisherScreen = true;
            base.Update(gameTime);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            teamLogo(spriteBatch);
            if(drawPublisherScreen)
                publisherLogo(spriteBatch);
            
        }
        public void teamLogo(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(celestialSoft, Vector2.Zero, Color.White);
        }
        public void publisherLogo(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(cognitiveThought, Vector2.Zero, Color.White);
        }
    }
}

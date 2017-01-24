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
            base.Update(gameTime);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(celestialSoft, Vector2.Zero, Color.White);
            spriteBatch.Draw(cognitiveThought, Vector2.Zero, Color.White);
        }
    }
}

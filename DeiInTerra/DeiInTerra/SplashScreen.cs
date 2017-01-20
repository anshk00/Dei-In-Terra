using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
namespace DeiInTerra
{
    class SplashScreen : GameScreen
    {
        Texture2D celestialSoft, cognitiveThought;
        string path1, path2;
        
        public override void LoadContent()
        {
            base.LoadContent();
            path1 = "SplashScreen/CelestialSoft";
            path2 = "SplashScreen/CognitiveThought";
            celestialSoft = content.Load<Texture2D>(path1);
            cognitiveThought = content.Load<Texture2D>(path2);
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

        }
    }
}

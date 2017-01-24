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
    public class ScreenManager
    {
        private static ScreenManager instance;
        public ContentManager Content { private set; get; }
        public Vector2 Dimensions { private set; get; }
        //XmlManager<GameScreen> xmlGameScreenManager;
        GameScreen currentScreen;

        public static ScreenManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ScreenManager();
                    
                }
                return instance;
            }
        }

        public ScreenManager()
        {
            Dimensions = new Vector2(800, 600);
            currentScreen = new SplashScreen();
            //xmlGameScreenManager = new XmlManager<GameScreen>();
            //xmlGameScreenManager.Type = currentScreen.Type;
            //currentScreen = xmlGameScreenManager.Load("Content/XML/SplashScreen.xml");
        }

        public void LoadContent(ContentManager Content)
        {
            this.Content = new ContentManager(Content.ServiceProvider, "Content");
            currentScreen.LoadContent();
        }

        public void UnloadContent()
        {
            currentScreen.UnloadContent();
        }

        public void Update(GameTime gameTime)
        {
            currentScreen.Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            currentScreen.Draw(spriteBatch);
        }

    }
}

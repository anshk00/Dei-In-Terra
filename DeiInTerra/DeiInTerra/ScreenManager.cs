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
        public bool isTransitioning =false;

        private GameScreen currentScreen;

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

        public void changeScreens(GameScreen nextScreen)
        {
            isTransitioning = true;
            UnloadContent();
            currentScreen = nextScreen;
            LoadContent(Content);
            isTransitioning = false;
        }
    }
}
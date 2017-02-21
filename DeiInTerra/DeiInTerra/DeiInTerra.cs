using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended;

namespace DeiInTerra
{
    /// <summary>
    /// Main class for Dei In Terra
    /// </summary>

    public class DeiInTerra : Game
    {
        public GraphicsDeviceManager graphics { get; set; }
        private SpriteBatch spriteBatch;
        private FramesPerSecondCounter fpsCounter;
        private SpriteFont spriteFont;
        private Vector2 fpsLocation;
        public DeiInTerra()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            fpsCounter = new FramesPerSecondCounter(60);
            fpsLocation =  new Vector2((float)(9/10f)*(ScreenManager.Instance.Dimensions.X), (float) (1/20f)*ScreenManager.Instance.Dimensions.Y);
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            graphics.PreferredBackBufferWidth = (int)ScreenManager.Instance.Dimensions.X;
            graphics.PreferredBackBufferHeight = (int)ScreenManager.Instance.Dimensions.Y;
            graphics.ApplyChanges();
            IsMouseVisible = true;
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            ScreenManager.Instance.LoadContent(Content);
            spriteFont = Content.Load<SpriteFont>("GameFont");
            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
            ScreenManager.Instance.UnloadContent();
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            ScreenManager.Instance.Update(gameTime);
            InputManager.Instance.Update(gameTime);
            fpsCounter.Update(gameTime);
            
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();
            ScreenManager.Instance.Draw(spriteBatch);
            int fpsValue = (int)fpsCounter.CurrentFramesPerSecond;
            spriteBatch.DrawString(spriteFont, fpsValue.ToString(), fpsLocation, Color.White);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
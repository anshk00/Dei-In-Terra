using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended.Animations;
using MonoGame.Extended.Maps.Tiled;

namespace DeiInTerra
{
    internal class GameplayScreen : GameScreen
    {
        private Player player;
        private TiledMap currentLevel;

        public override void LoadContent()
        {
            base.LoadContent();
            player = new Player("Archer");
            player.LoadContent();
            currentLevel = base.content.Load<TiledMap>("LevelSelect/TestLevel");
        }

        public override void UnloadContent()
        {
            base.UnloadContent();
            player.UnloadContent();
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            player.Update(gameTime);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);

            currentLevel.Draw(spriteBatch, new Rectangle(Vector2.Zero.ToPoint(), ScreenManager.Instance.Dimensions.ToPoint()));
            player.Draw(spriteBatch);
        }
    }
}
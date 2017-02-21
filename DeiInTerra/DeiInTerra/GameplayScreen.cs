using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended.Maps;
using MonoGame.Extended.Maps.Tiled;
using MonoGame.Extended.Animations;
using MonoGame.Extended;

namespace DeiInTerra
{
    class GameplayScreen : GameScreen
    {
        Player player;
        TiledMap currentLevel;
        SpriteSheetAnimation walk;
        SpriteSheetAnimator animator;


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

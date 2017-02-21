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

namespace DeiInTerra
{
    class GameplayScreen : GameScreen
    {
        Player player;
        Texture2D currentLevel;
        SpriteSheetAnimation walk;
        SpriteSheetAnimator animator;

        public override void LoadContent()
        {
            base.LoadContent();
            player = new Player("Archer");
            player.LoadContent();
            currentLevel = base.content.Load<Texture2D>("LevelSelect/Shop");

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
            
            spriteBatch.Draw(currentLevel, Vector2.Zero, Color.White);
            player.Draw(spriteBatch);
        }
    }
}

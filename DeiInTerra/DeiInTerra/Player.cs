using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;
using MonoGame.Extended.Sprites;


namespace DeiInTerra
{
    internal class Player : Character
    {

        ContentManager content;
        public Vector2 Velocity;
        public float MoveSpeed;
        Sprite playerSprite;
        public Player(string playerClass)
        {
            content = new ContentManager(ScreenManager.Instance.Content.ServiceProvider, "Content/Player");
            Velocity = Vector2.Zero;
            MoveSpeed = 100f;
            health = 100;
            totalHealth = 100;
            mana = 100;
            totalMana = 100;
            playerType = playerClass;
        }

        public void LoadContent()
        {
            playerSprite = new Sprite(content.Load<Texture2D>(playerType));
        }

        public void UnloadContent()
        {
            content.Unload();
        }
        
        public void Update(GameTime gameTime)
        {
            UpdateVelocity(gameTime);
        }

        public void UpdateVelocity(GameTime gameTime)
        {
            if(Velocity.X ==0)
            {
                if (InputManager.Instance.KeyDown(Keys.S, Keys.Down))
                    Velocity.Y = MoveSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
                else if (InputManager.Instance.KeyDown(Keys.Up, Keys.W))
                {
                    Velocity.Y = -MoveSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
                }
                else
                {
                    Velocity.Y = 0;
                }
            }

            if(Velocity.Y ==0)
            {
                if (InputManager.Instance.KeyDown(Keys.Right, Keys.D))
                {
                    Velocity.X = MoveSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
                }
                else if (InputManager.Instance.KeyDown(Keys.Left, Keys.A))
                {
                    Velocity.X = -MoveSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
                }
                else
                {
                    Velocity.X = 0;
                }
            }



        }

        public void Draw(SpriteBatch spriteBatch)
        {

        }

        public int SkillPoints
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }
}
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;

namespace DeiInTerra
{
    internal class Player : Character
    {
        public Vector2 Velocity;
        public float MoveSpeed;


        public Player(Texture2D playerTexture)
        {
            Velocity = Vector2.Zero;
            health = 100;
            totalHealth = 100;
            mana = 100;
            totalMana = 100;
            model = playerTexture;
        }

        public void LoadContent()
        {

        }

        public void UnloadContent()
        {

        }
        
        public void Update(GameTime gameTime)
        {
            
                


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
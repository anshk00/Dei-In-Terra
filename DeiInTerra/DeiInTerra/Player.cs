using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame.Extended;

namespace DeiInTerra
{
    internal class Player : Character
    {
        public enum Direction {Left, Right};
        public Vector2 coords;

        public Player(Texture2D a, float ScreenWidth, float ScreenHeight)
        {
            health = 100;
            totalHealth = 100;
            mana = 100;
            totalMana = 100;
            model = a;
            coords = new Vector2(ScreenWidth * (.5f), ScreenHeight * (405 / 600f));
        }

        public int skillPoints
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public void setDirection()
        {

        }
        public void moveLeft()
        {

        }
        public void moveRight()
        {

        }
        public void moveJump()
        {

        }
        public void adjustStats()
        {
            
        }

    }
}
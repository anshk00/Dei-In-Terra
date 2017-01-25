using Microsoft.Xna.Framework.Graphics;

namespace DeiInTerra
{
    internal class Player : Character
    {
        public Player(Texture2D a, float ScreenWidth, float ScreenHeight)
        {
            health = 100;
            totalHealth = 100;
            mana = 100;
            totalMana = 100;
            model = a;
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
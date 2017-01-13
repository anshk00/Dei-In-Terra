using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame.Extended;

namespace DeiInTerra
{
    internal class Player : Character
    {
        

        public Player(Texture2D b)
        {
            health = 100;
            totalHealth = 100;
            mana = 100;
            totalMana = 100;
            model = b;
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


        public void moveLeft()
        {

        }
        public void moveRight()
        {

        }
        public void adjustStats()
        {
            
        }

    }
}
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace DeiInTerra
{
    internal class Player : Character
    {
        public Player(Texture2D a)
        {
            health = 100;
            totalHealth = 100;
            mana = 100;
            totalMana = 100;
            model = a;
        }
        
        public override void move()
        {
            base.move();
        }
    }
}
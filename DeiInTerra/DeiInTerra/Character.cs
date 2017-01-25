using Microsoft.Xna.Framework.Graphics;

namespace DeiInTerra
{
    internal abstract class Character
    {
        public enum moveDirection { None, Left, Right, Up, Down };

        public int health { get; set; }
        public int mana { get; set; }
        public int totalHealth { get; set; }
        public int totalMana { get; set; }
        public string name { get; set; }
        public Texture2D model { get; set; }

        public virtual void move()
        {
        }

        public virtual void attack()
        {
        }
    }
}
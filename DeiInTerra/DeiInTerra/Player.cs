using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeiInTerra
{
    class Player: Character
    {
        public Player()
        {
            health = 100;
            totalHealth = 100;
            mana = 100;
            totalMana = 100;
        }
        public override void move()
        {
            base.move();
        }
    }
}

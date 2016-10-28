using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeiInTerra
{
    abstract class Character
    {
        public int health { get; set; }
        public int mana { get; set; }
        public int totalHealth { get; set; }
        public int totalMana { get; set; }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;

namespace DeiInTerra
{
    public class Button
    {
        public Rectangle dimensions {get; private set;}

        public Button (int int1, int int2, int int3, int int4)
        {
            setDimensions(int1, int2, int3, int4);
        }
        public void setDimensions(int int1, int int2, int int3, int int4)
        {
            dimensions = new Rectangle (int1, int2, int3, int4);
        }
    }
}
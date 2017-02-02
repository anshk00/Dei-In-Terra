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
        public string buttonLabel { get; private set; }

        public Button (int int1, int int2, int int3, int int4, string buttonName)
        {
            SetDimensions(int1, int2, int3, int4);
            buttonLabel = buttonName;
        }

        public Button (Vector2 origin, Vector2 size, string buttonName)
        {
            SetDimensions(origin, size);
            buttonLabel = buttonName;
        }

        public void SetDimensions(int int1, int int2, int int3, int int4)
        {
            dimensions = new Rectangle (int1, int2, int3, int4);
        }

        public void SetDimensions(Vector2 origin, Vector2 size)
        {
            dimensions = new Rectangle(origin.ToPoint(), size.ToPoint())
        }
    }
}
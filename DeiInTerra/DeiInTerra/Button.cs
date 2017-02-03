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
        public Vector2 stringOrigin { get; private set; }
        public string buttonLabel { get; private set; }


        public Button (Vector2 origin, Vector2 size, string buttonName)
        {
            SetDimensions(origin, size);
            buttonLabel = buttonName;
        }

        public void SetDimensions(Vector2 origin, Vector2 size)
        {
            dimensions = new Rectangle(origin.ToPoint(), size.ToPoint());
            Vector2 stringOffset = Vector2.Divide(size, 8f);
            stringOrigin = new Vector2(origin.X + stringOffset.X, origin.Y + stringOffset.Y);
        }
    }
}
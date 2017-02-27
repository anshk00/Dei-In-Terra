using Microsoft.Xna.Framework;

namespace DeiInTerra
{
    /// <summary>
    /// Creates a "button" defined by a set of Vector2 parameters. 
    /// Also assists with using the drawString() method by creating a Vector2 to assist positioning the string.
    /// </summary>
    public class Button
    {
        public Rectangle dimensions { get; private set; }
        public Vector2 stringOrigin { get; private set; }
        public string buttonLabel { get; private set; }

        public Button(Vector2 origin, Vector2 size, string buttonName)
        {
            SetDimensions(origin, size);
            buttonLabel = buttonName;
        }

        public void SetDimensions(Vector2 origin, Vector2 size)
        {
            dimensions = new Rectangle(origin.ToPoint(), size.ToPoint());
            Vector2 stringOffset = Vector2.Divide(size, 2f);
            stringOrigin = Vector2.Add(origin, stringOffset);
        }
    }
}
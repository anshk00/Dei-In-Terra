using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace DeiInTerra
{
    internal class InputManager
    {
        private KeyboardState currentKeyState, oldKeyState;
        private MouseState currentMouseState, oldMouseState;
        private static InputManager instance;

        public static InputManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new InputManager();
                }
                return instance;
            }
        }

        public void Update(GameTime gameTime)
        {
            oldKeyState = currentKeyState;
            oldMouseState = currentMouseState;
            if (!ScreenManager.Instance.isTransitioning)
            {
                currentKeyState = Keyboard.GetState();
                currentMouseState = Mouse.GetState();
            }
        }

        public bool KeyPressed(params Keys[] keys)
        {
            foreach (Keys key in keys)
            {
                if (currentKeyState.IsKeyDown(key) && oldKeyState.IsKeyUp(key))
                {
                    return true;
                }
            }
            return false;
        }

        public bool KeyReleased(params Keys[] keys)
        {
            foreach (Keys key in keys)
            {
                if (currentKeyState.IsKeyUp(key) && oldKeyState.IsKeyDown(key))
                {
                    return true;
                }
            }
            return false;
        }

        public bool KeyDown(params Keys[] keys)
        {
            foreach (Keys key in keys)
            {
                if (currentKeyState.IsKeyDown(key))
                {
                    return true;
                }
            }
            return false;
        }

        public bool LeftButtonDown()
        {
            if (currentMouseState.LeftButton.Equals(ButtonState.Pressed)
                && oldMouseState.LeftButton.Equals(ButtonState.Released))
                return true;
            else
                return false;
        }

        public bool RightButtonDown()
        {
            if (currentMouseState.RightButton.Equals(ButtonState.Pressed)
                && oldMouseState.RightButton.Equals(ButtonState.Released))
                return true;
            else
                return false;
        }

        public bool CheckCursorLocation(Rectangle Dimensions)
        {
            return Dimensions.Contains(currentMouseState.Position.ToVector2());
        }
    }
}
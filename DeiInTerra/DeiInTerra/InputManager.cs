using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework.Input;
namespace DeiInTerra
{
    class InputManager
    {
        KeyboardState currentKeyState, oldKeyState;

        private static InputManager instance;

        public static InputManager Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new InputManager();
                }
                return instance;
            }
        }
        public void Update()
        {
            oldKeyState = currentKeyState;
            if (!ScreenManager.Instance.isTransitioning)
            {
                currentKeyState = Keyboard.GetState();
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
                if (currentKeyState.IsKeyDown(key) )
                {
                    return true;    
                }
            }
            return false;
        }

        public bool LeftButtonDown(params Vector2[] Dimensions)
        {
            
        }
    }
}

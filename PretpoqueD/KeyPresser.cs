using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Native;

namespace PretpoqueD
{
    class KeyPresser
    {
        private static InputSimulator Simulator = new InputSimulator();

        private KeyPresser()
        {
            this.Keyless = true;
        }

        private KeyPresser(VirtualKeyCode key)
        {
            this.Key = key;
        }

        internal static KeyPresser FromKeyname(string keyCode)
        {
            VirtualKeyCode tmpKey;
            if (Enum.TryParse<VirtualKeyCode>(keyCode, true, out tmpKey))
            {
                return new KeyPresser(tmpKey);
            }
            else
            {
                return new KeyPresser();
            }
        }

        public VirtualKeyCode Key { get; private set; }

        public bool Keyless { get; private set; }

        public bool WasPressed { get; private set; }

        internal void SetState(bool isPressed)
        {
            if (!Keyless) {
                if (isPressed && !WasPressed)
                {
                    switch (Key)
                    {
                        case VirtualKeyCode.LBUTTON:
                            Simulator.Mouse.LeftButtonDown(); 
                            break;
                        case VirtualKeyCode.RBUTTON:
                            Simulator.Mouse.RightButtonDown();
                            break;
                        default:
                            Simulator.Keyboard.KeyDown(Key);
                            break;
                    }

                }
                else if (!isPressed && WasPressed)
                {
                    switch (Key)
                    {
                        case VirtualKeyCode.LBUTTON:
                            Simulator.Mouse.LeftButtonUp();
                            break;
                        case VirtualKeyCode.RBUTTON:
                            Simulator.Mouse.RightButtonUp();
                            break;
                        default:
                            Simulator.Keyboard.KeyUp(Key);
                            break;
                    }
                }

                this.WasPressed = isPressed;
            }
        }
    }
}

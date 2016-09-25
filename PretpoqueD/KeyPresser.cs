using PretpoqueCommon;
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

        private KeyPresser(ExtendedVirtualKeyCode key)
        {
            this.Key = key;
        }

        internal static KeyPresser FromKeyname(string keyCode)
        {
            ExtendedVirtualKeyCode tmpKey;
            if (Enum.TryParse<ExtendedVirtualKeyCode>(keyCode, true, out tmpKey))
            {
                return new KeyPresser(tmpKey);
            }
            else
            {
                return new KeyPresser();
            }
        }

        public ExtendedVirtualKeyCode Key { get; private set; }

        public bool Keyless { get; private set; }

        public bool WasPressed { get; private set; }

        internal void SetState(bool isPressed)
        {
            if (!Keyless) {
                if (isPressed && !WasPressed)
                {
                    switch (Key)
                    {
                        case ExtendedVirtualKeyCode.LBUTTON:
                            Simulator.Mouse.LeftButtonDown(); 
                            break;
                        case ExtendedVirtualKeyCode.RBUTTON:
                            Simulator.Mouse.RightButtonDown();
                            break;
                        case ExtendedVirtualKeyCode.WHEEL_DOWN:
                            Simulator.Mouse.VerticalScroll(-1);
                            break;
                        case ExtendedVirtualKeyCode.WHEEL_UP:
                            Simulator.Mouse.VerticalScroll(1);
                            break;
                        default:
                            Simulator.Keyboard.KeyDown((VirtualKeyCode)Key);
                            break;
                    }

                }
                else if (!isPressed && WasPressed)
                {
                    switch (Key)
                    {
                        case ExtendedVirtualKeyCode.LBUTTON:
                            Simulator.Mouse.LeftButtonUp();
                            break;
                        case ExtendedVirtualKeyCode.RBUTTON:
                            Simulator.Mouse.RightButtonUp();
                            break;
                        default:
                            Simulator.Keyboard.KeyUp((VirtualKeyCode)Key);
                            break;
                    }
                }

                this.WasPressed = isPressed;
            }
        }
    }
}

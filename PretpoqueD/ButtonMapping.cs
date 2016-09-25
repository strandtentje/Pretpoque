using BorrehSoft.Utensils.Collections.Settings;
using OpenTK.Input;
using PretpoqueCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsInput;
using ButtonState = OpenTK.Input.ButtonState;

namespace PretpoqueD
{
    class ButtonMapping
    {
        public int ButtonIndex { get; private set; }

        public KeyPresser ToKeyboard { get; private set; }

        private ButtonMapping(int buttonIndex)
        {
            this.ButtonIndex = buttonIndex;
        }

        internal static ButtonMapping FromSettings(Settings settings, int buttonIndex)
        {
            Settings buttonSettings = settings.GetSubsettings("button" + buttonIndex);
            string keyName = buttonSettings.GetString(SettingsKeys.ButtonKey, "");

            return new ButtonMapping(buttonIndex)
            {
                ToKeyboard = KeyPresser.FromKeyname(keyName)
            };
        }

        internal void ControllerPolled(object sender, Bootstrapper.ControllerPollEventArgs e)
        {
            bool isButtonPressed = e.State.GetButton((JoystickButton)ButtonIndex) == ButtonState.Pressed;
            this.ToKeyboard.SetState(isButtonPressed);
        }
    }
}

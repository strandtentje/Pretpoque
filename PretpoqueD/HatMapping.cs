using BorrehSoft.Utensils.Collections.Settings;
using OpenTK.Input;
using PretpoqueCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PretpoqueD
{
    class HatMapping
    {
        public KeyPresser HatUp { get; private set; }
        public KeyPresser HatDown { get; private set; }
        public KeyPresser HatLeft { get; private set; }
        public KeyPresser HatRight { get; private set; }

        public int HatIndex { get; private set; }

        private HatMapping(int hatIndex)
        {
            this.HatIndex = hatIndex;
        }

        public static HatMapping FromSettings(Settings settings, int hatIndex)
        {
            Settings subsettings = settings.GetSubsettings("hat" + hatIndex);

            return new HatMapping(hatIndex)
            {
                HatUp = KeyPresser.FromKeyname(subsettings.GetString(SettingsKeys.HatUpKey, "")),
                HatDown = KeyPresser.FromKeyname(subsettings.GetString(SettingsKeys.HatDownKey, "")),
                HatLeft = KeyPresser.FromKeyname(subsettings.GetString(SettingsKeys.HatLeftKey, "")),
                HatRight = KeyPresser.FromKeyname(subsettings.GetString(SettingsKeys.HatRightKey, ""))
            };
        }   
        
        public void ControllerPolled(object sender, Bootstrapper.ControllerPollEventArgs e)
        {
            JoystickHatState hatState = e.State.GetHat((JoystickHat)this.HatIndex);

            HatUp.SetState(hatState.IsUp);
            HatDown.SetState(hatState.IsDown);
            HatLeft.SetState(hatState.IsLeft);
            HatRight.SetState(hatState.IsRight);
        }     
    }
}

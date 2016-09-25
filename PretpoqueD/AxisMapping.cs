using BorrehSoft.Utensils.Collections.Settings;
using OpenTK.Input;
using PretpoqueCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Native;

namespace PretpoqueD
{
    class AxisMapping
    {
        private static InputSimulator Simulator = new InputSimulator();

        const float SETTINGS_INTERVAL = 10f;
        const float REAL_INTERVAL = 100f;
        const float SETTINGS_SCALE = 100f;
        const float CORRECTION = (SETTINGS_INTERVAL / REAL_INTERVAL * SETTINGS_SCALE);
        
        public float MouseX;

        public float MouseY;

        public float LowTrigger;

        public float HighTrigger;

        public int AxisIndex { get; private set; }
        
        public KeyPresser LowTriggerKey { get; private set; }

        public KeyPresser HighTriggerKey { get; private set; }

        private AxisMapping(int axisIndex)
        {
            this.AxisIndex = axisIndex;
        }
        
        internal static AxisMapping FromSettings(Settings settings, int axisIndex) {
            Settings subsettings = settings.GetSubsettings("axis" + axisIndex);

            return new AxisMapping(axisIndex)
            {
                MouseX = (float)subsettings.GetInt(SettingsKeys.MouseXSensitivity) / CORRECTION,
                MouseY = (float)subsettings.GetInt(SettingsKeys.MouseYSensitivity) / CORRECTION,
                LowTrigger = (float)subsettings.GetInt(SettingsKeys.LowTriggerLevel) / SETTINGS_SCALE,
                HighTrigger = (float)subsettings.GetInt(SettingsKeys.HighTriggerLevel) / SETTINGS_SCALE,
                LowTriggerKey = KeyPresser.FromKeyname(subsettings.GetString(SettingsKeys.LowTriggerKey, "")),
                HighTriggerKey = KeyPresser.FromKeyname(subsettings.GetString(SettingsKeys.HighTriggerKey, "")),
            };
        }

        internal void ControllerPolled(object sender, Bootstrapper.ControllerPollEventArgs e)
        {   
            float axisValue = e.State.GetAxis((JoystickAxis)this.AxisIndex);

            Simulator.Mouse.MoveMouseBy(
                (int)(axisValue * this.MouseX),
                (int)(axisValue * this.MouseY)
            );

            this.HighTriggerKey.SetState(axisValue < this.LowTrigger);
            this.LowTriggerKey.SetState(axisValue > this.HighTrigger);
        }
    }
}

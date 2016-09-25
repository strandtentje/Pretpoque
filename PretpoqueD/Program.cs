using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using BorrehSoft.Utensils.Log;
using WindowsInput;
using OpenTK.Input;
using PretpoqueCommon;
using BorrehSoft.Utensils.Collections.Settings;
using System.Timers;
using Keys = System.Windows.Forms.Keys;
using DialogResult = System.Windows.Forms.DialogResult;

namespace PretpoqueD
{
    class Bootstrapper
    {
        public class ControllerPollEventArgs
        {
            public JoystickState State;
        }
        delegate void ControllerPollEventHandler(object sender, ControllerPollEventArgs e);
        static event ControllerPollEventHandler ControllerPoll;

        static InputSimulator simulator;
        static int selectedJoystick;
        static AxisMapping[] axis;
        static ButtonMapping[] buttons;
        static HatMapping[] hats;

        static void Main(string[] args)
        {
            string time = DateTime.Now.ToString("yyyy-MM-dd--THHmmsszz");
            Secretary logger = new Secretary(time + ".log");
            logger.globVerbosity = 10;
            logger.ReportHere(0, "Logfile Opened");

            ControllerPicker picker = new ControllerPicker();
            
            if (picker.ShowDialog() == DialogResult.OK) {
                selectedJoystick = picker.SelectedControllerIndex;
                Settings settings = SettingsParser.FromFile("default.conf");                
                JoystickCapabilities capabilities = Joystick.GetCapabilities(selectedJoystick);

                ConfigureAxis(settings, capabilities);
                ConfigureButtons(settings, capabilities);
                ConfigureHats(settings, capabilities);

                Timer pollThread = new Timer(10) { AutoReset = true, };
                pollThread.Elapsed += pollThread_Elapsed;
                pollThread.Start();
            }
        }

        private static void ConfigureButtons(Settings settings, JoystickCapabilities capabilities)
        {
            buttons = new ButtonMapping[capabilities.ButtonCount];

            for (int i = 0; i < capabilities.ButtonCount; i++)
            {
                buttons[i] = ButtonMapping.FromSettings(settings, i);
                ControllerPoll += buttons[i].ControllerPolled;
            }
        }

        private static void ConfigureAxis(Settings settings, JoystickCapabilities capabilities)
        {
            axis = new AxisMapping[capabilities.AxisCount];

            for (int i = 0; i < capabilities.AxisCount; i++)
            {
                axis[i] = AxisMapping.FromSettings(settings, i);
                ControllerPoll += axis[i].ControllerPolled;
            }
        }

        private static void ConfigureHats(Settings settings, JoystickCapabilities capabilities)
        {
            hats = new HatMapping[capabilities.HatCount];

            for (int i = 0; i < capabilities.HatCount; i++)
            {
                hats[i] = HatMapping.FromSettings(settings, i);
                ControllerPoll += hats[i].ControllerPolled;
            }
        }

        static void pollThread_Elapsed(object sender, ElapsedEventArgs e)
        {
            JoystickState currentState = Joystick.GetState(selectedJoystick);

            if (ControllerPoll != null)
            {
                ControllerPoll(null, new ControllerPollEventArgs() { State = currentState });
            }
        }
    }
}

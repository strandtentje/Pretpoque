using BorrehSoft.Utensils.Collections.Settings;
using OpenTK.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PretpoqueD
{
    public partial class ControllerBinder : Form
    {
        private int ControllerIndex;
        private JoystickCapabilities Capabilities;

        public ControllerBinder(int controllerIndex)
        {
            this.InitializeComponent();

            this.ControllerIndex = controllerIndex;
            this.Capabilities = Joystick.GetCapabilities(this.ControllerIndex);
            this.DialogResult = DialogResult.Cancel;

            Settings storedConfig = SettingsParser.FromFile("default.conf");

            for (int axisIndex = 0; axisIndex < this.Capabilities.AxisCount; axisIndex++)
            {
                this.AxisGroup.Controls.Add(new AxisConfig(axisIndex) {
                    Settings = storedConfig.GetSubsettings("axis" + axisIndex)
                });
            }

            for (int hatIndex = 0; hatIndex < this.Capabilities.HatCount; hatIndex++)
            {
                this.HatGroup.Controls.Add(new HatConfig(hatIndex) {
                    Settings = storedConfig.GetSubsettings("hat" + hatIndex)
                });
            }

            for (int buttonIndex = 0; buttonIndex < this.Capabilities.ButtonCount; buttonIndex++)
            {
                this.ButtonGroup.Controls.Add(new ButtonConfig(buttonIndex) {
                    Settings = storedConfig.GetSubsettings("button" + buttonIndex)
                });
            }
        }

        private void ExitConfig_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StartBindings_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ControllerPoller_Tick(object sender, EventArgs e)
        {
            JoystickState state = Joystick.GetState(this.ControllerIndex);

            UpdateGroup(AxisGroup, state);
            UpdateGroup(HatGroup, state);
            UpdateGroup(ButtonGroup, state);
        }

        private void UpdateGroup(FlowLayoutPanel group, JoystickState state)
        {
            IControllerComponentConfig configControl;

            foreach (Control control in group.Controls)
            {
                configControl = control as IControllerComponentConfig;
                if (configControl != null)
                {
                    configControl.UpdateState(state);
                }
            }
        }

        private void BinderVisible(object sender, EventArgs e)
        {
            this.ControllerPoller.Enabled = true;
        }

        private void ControllerBinder_Load(object sender, EventArgs e)
        {

        }
    }
}

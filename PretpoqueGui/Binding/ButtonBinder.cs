using BorrehSoft.Utensils.Collections.Settings;
using Composing;
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

namespace PretpoqueGui
{
    public partial class ButtonBinder : Form
    {
        private int ControllerIndex;
        private JoystickCapabilities Capabilities;
        private List<IControllerComponentConfig> Configurators = new List<IControllerComponentConfig>();
        private Settings StoredConfig;

        public ButtonBinder(int controllerIndex)
        {
            this.InitializeComponent();

            this.ControllerIndex = controllerIndex;
            this.Capabilities = Joystick.GetCapabilities(this.ControllerIndex);
            this.DialogResult = DialogResult.Cancel;
            this.StoredConfig = SettingsParser.FromFile("default.conf");

            for (int axisIndex = 0; axisIndex < this.Capabilities.AxisCount; axisIndex++)
            {
                RegisterConfigurator(new AxisConfig(axisIndex));
            }

            for (int hatIndex = 0; hatIndex < this.Capabilities.HatCount; hatIndex++)
            {
                RegisterConfigurator(new HatConfig(hatIndex));
            }

            for (int buttonIndex = 0; buttonIndex < this.Capabilities.ButtonCount; buttonIndex++)
            {
                RegisterConfigurator(new ButtonConfig(buttonIndex));
            }
        }

        private void RegisterConfigurator(IControllerComponentConfig configurator)
        {
            this.Configurators.Add(configurator);
            configurator.Settings = this.StoredConfig.GetSubsettings(configurator.ConfigName);

            if (configurator is AxisConfig) this.AxisGroup.Controls.Add(configurator as Control);
            if (configurator is HatConfig) this.HatGroup.Controls.Add(configurator as Control);
            if (configurator is ButtonConfig) this.ButtonGroup.Controls.Add(configurator as Control);
        }

        private void ExitConfig_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StartBindings_Click(object sender, EventArgs e)
        {
            Settings allSettings = new Settings();

            foreach (IControllerComponentConfig configurator in this.Configurators)
            {
                allSettings[configurator.ConfigName] = configurator.Settings;
            }

            SettingsComposer composer = new SettingsComposer("    ");

            composer.SettingsToFile(allSettings, "default.conf");

            MessageBox.Show("Settings saved to default.conf", "Saved", MessageBoxButtons.OK);
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

        private void ButtonBinder_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(
                "Are you sure you want to close the configurator? " +
                "Unsaved changes will be lost.", 
                "Closing", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}

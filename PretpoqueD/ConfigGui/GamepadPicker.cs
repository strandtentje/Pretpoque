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
    public partial class ControllerPicker : Form
    {
        public int SelectedControllerIndex
        {
            get
            {
                return this.ControllerList.SelectedIndex;
            }
        }

        public ControllerPicker()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;

            this.ControllerList.DisplayMember = "Name";
            this.ControllerList.ValueMember = "Index";

            for (int controllerIndex = 0; Joystick.GetState(controllerIndex).IsConnected; controllerIndex++)
            {
                this.ControllerList.Items.Add(new ControllerItem(controllerIndex));
            }
        }

        private void ControllerChosenByButton(object sender, EventArgs e)
        {
            finalizeChoice();
        }

        private void CancelLaunchButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeviceListMutation(object sender, EventArgs e)
        {
            this.AcceptControllerButton.Enabled = this.SelectedControllerIndex > -1;
        }

        private void GamepadChosenFromList(object sender, EventArgs e)
        {
            if (this.AcceptControllerButton.Enabled) finalizeChoice();
        }

        private void finalizeChoice()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

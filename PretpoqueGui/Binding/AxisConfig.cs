using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenTK.Input;
using BorrehSoft.Utensils.Collections.Settings;
using NamedKey = System.Collections.Generic.KeyValuePair<string, System.Windows.Forms.Keys>;
using PretpoqueCommon;

namespace PretpoqueGui
{
    public partial class AxisConfig : UserControl, IControllerComponentConfig
    {
        private int AxisIndex;
        
        public AxisConfig(int axisIndex)
        {
            InitializeComponent();
            this.AxisIndex = axisIndex;
            this.Text = "Axis" + this.AxisIndex;

            KeyList.PrimeComboBox(LowTriggerKey);
            KeyList.PrimeComboBox(HighTriggerKey);
        }

        public void UpdateState(JoystickState state)
        {
            float rawValue = state.GetAxis((JoystickAxis)this.AxisIndex);
            this.AxisPosition.Value = (int)(100 * rawValue);
            this.LowTriggerOn.Checked = this.AxisPosition.Value < this.LowTriggerLevel.Value;
            this.HighTriggerOn.Checked = this.AxisPosition.Value > this.HighTriggerLevel.Value;
            
            Win32Interop.Structs.POINT currentPos;
            Win32Interop.Methods.User32.GetCursorPos(out currentPos);
            Win32Interop.Methods.User32.SetCursorPos(
                currentPos.x + (int)(rawValue * (float)this.MouseXMult.Value),
                currentPos.y + (int)(rawValue * (float)this.MouseYMult.Value)
            );
        }

        private void ResetTrackbar(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'r')
            {
                ((TrackBar)sender).Value = 0;
            }
        }
        
        public Settings Settings {
            get
            {
                Settings settings = new Settings();

                settings[SettingsKeys.MouseXSensitivity] = this.MouseXMult.Value;
                settings[SettingsKeys.MouseYSensitivity] = this.MouseYMult.Value;
                settings[SettingsKeys.LowTriggerLevel] = this.LowTriggerLevel.Value;
                settings[SettingsKeys.HighTriggerLevel] = this.HighTriggerLevel.Value;

                settings[SettingsKeys.LowTriggerKey] = this.LowTriggerKey.Text;
                settings[SettingsKeys.HighTriggerKey] = this.HighTriggerKey.Text;
                
                return settings;
            }
            set
            {
                this.MouseXMult.Value = value.GetInt(SettingsKeys.MouseXSensitivity, 0);
                this.MouseYMult.Value = value.GetInt(SettingsKeys.MouseYSensitivity, 0);
                this.LowTriggerLevel.Value = value.GetInt(SettingsKeys.LowTriggerLevel, -10);
                this.HighTriggerLevel.Value = value.GetInt(SettingsKeys.HighTriggerLevel, 10);

                if (value.Has(SettingsKeys.LowTriggerKey))
                {
                    this.LowTriggerKey.SelectedText = value.GetString(SettingsKeys.LowTriggerKey);
                }

                if (value.Has(SettingsKeys.HighTriggerKey))
                {
                    this.HighTriggerKey.SelectedText = value.GetString(SettingsKeys.HighTriggerKey);
                }
            }
        }

        public string ConfigName
        {
            get { return "axis" + AxisIndex; }
        }
    }
}

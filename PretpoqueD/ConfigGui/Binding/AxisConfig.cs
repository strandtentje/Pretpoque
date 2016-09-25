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

namespace PretpoqueD
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

        static class SettingsKey
        {
            public const string MouseXSensitivity = "mousexsensitivity";
            public const string MouseYSensitivity = "mouseysensitivity";
            public const string LowTriggerLevel = "lowtriggerlevel";
            public const string HighTriggerLevel = "hightriggerlevel";
            public const string LowTriggerKey = "lowtriggerkey";
            public const string HighTriggerKey = "hightriggerkey";
        }

        public Settings Settings {
            get
            {
                Settings settings = new Settings();

                settings[SettingsKey.MouseXSensitivity] = this.MouseXMult.Value;
                settings[SettingsKey.MouseYSensitivity] = this.MouseYMult.Value;
                settings[SettingsKey.LowTriggerLevel] = this.LowTriggerLevel.Value;
                settings[SettingsKey.HighTriggerLevel] = this.HighTriggerLevel.Value;

                if (this.LowTriggerKey.SelectedItem is NamedKey)
                {
                    settings[SettingsKey.LowTriggerKey] = this.LowTriggerKey.SelectedText;
                }

                if (this.HighTriggerKey.SelectedItem is NamedKey)
                {
                    settings[SettingsKey.HighTriggerKey] = this.HighTriggerKey.SelectedText;
                }

                return settings;
            }
            set
            {
                this.MouseXMult.Value = value.GetInt(SettingsKey.MouseXSensitivity);
                this.MouseYMult.Value = value.GetInt(SettingsKey.MouseYSensitivity);
                this.LowTriggerLevel.Value = value.GetInt(SettingsKey.LowTriggerLevel);
                this.HighTriggerLevel.Value = value.GetInt(SettingsKey.HighTriggerLevel);

                if (value.Has(SettingsKey.LowTriggerKey))
                {
                    this.LowTriggerKey.SelectedText = value.GetString(SettingsKey.LowTriggerKey);
                }

                if (value.Has(SettingsKey.HighTriggerKey))
                {
                    this.HighTriggerKey.SelectedText = value.GetString(SettingsKey.HighTriggerKey);
                }
            }
        }
    }
}

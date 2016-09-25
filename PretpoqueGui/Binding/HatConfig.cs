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
    public partial class HatConfig : UserControl, IControllerComponentConfig
    {
        private int hatIndex;

        public HatConfig(int hatIndex)
        {
            InitializeComponent();
            this.hatIndex = hatIndex;
            KeyList.PrimeComboBox(HatUpKey);
            KeyList.PrimeComboBox(HatDownKey);
            KeyList.PrimeComboBox(HatLeftKey);
            KeyList.PrimeComboBox(HatRightKey);
        }

        public void UpdateState(JoystickState state)
        {
            JoystickHatState hatState = state.GetHat((JoystickHat)hatIndex);

            HatUpActive.Checked = hatState.IsUp;
            HatDownActive.Checked = hatState.IsDown;
            HatLeftActive.Checked = hatState.IsLeft;
            HatRightActive.Checked = hatState.IsRight;
        }
        
        public Settings Settings {
            get {
                Settings settings = new Settings();

                settings[SettingsKeys.HatUpKey] = HatUpKey.Text;
                settings[SettingsKeys.HatDownKey] = HatDownKey.Text;
                settings[SettingsKeys.HatLeftKey] = HatLeftKey.Text;
                settings[SettingsKeys.HatRightKey] = HatRightKey.Text;
            
                return settings;
            }
            set {
                if (value.Has(SettingsKeys.HatUpKey)) HatUpKey.SelectedText = value.GetString(SettingsKeys.HatUpKey);
                if (value.Has(SettingsKeys.HatDownKey)) HatDownKey.SelectedText = value.GetString(SettingsKeys.HatDownKey);
                if (value.Has(SettingsKeys.HatLeftKey)) HatLeftKey.SelectedText = value.GetString(SettingsKeys.HatLeftKey);
                if (value.Has(SettingsKeys.HatRightKey)) HatRightKey.SelectedText = value.GetString(SettingsKeys.HatRightKey);
            }
        }

        public string ConfigName
        {
            get { return "hat" + this.hatIndex; }
        }
    }
}

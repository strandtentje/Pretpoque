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

        public static class SettingKeys
        {
            public const string HatUpKey = "hatupkey";
            public const string HatDownKey = "hatdownkey";
            public const string HatLeftKey = "hatleftkey";
            public const string HatRightKey = "hatrightkey";
        }

        public Settings Settings {
            get {
                Settings settings = new Settings();

                if (HatUpKey.SelectedItem is NamedKey)
                {
                    settings[SettingKeys.HatUpKey] = HatUpKey.SelectedText;
                }

                if (HatDownKey.SelectedItem is NamedKey)
                {
                    settings[SettingKeys.HatDownKey] = HatDownKey.SelectedText;
                }

                if (HatLeftKey.SelectedItem is NamedKey)
                {
                    settings[SettingKeys.HatLeftKey] = HatLeftKey.SelectedText;
                }

                if (HatRightKey.SelectedItem is NamedKey)
                {
                    settings[SettingKeys.HatRightKey] = HatRightKey.SelectedText;
                }

                return settings;
            }
            set {
                if (value.Has(SettingKeys.HatUpKey)) HatUpKey.SelectedText = value.GetString(SettingKeys.HatUpKey);
                if (value.Has(SettingKeys.HatDownKey)) HatDownKey.SelectedText = value.GetString(SettingKeys.HatDownKey);
                if (value.Has(SettingKeys.HatLeftKey)) HatLeftKey.SelectedText = value.GetString(SettingKeys.HatLeftKey);
                if (value.Has(SettingKeys.HatRightKey)) HatRightKey.SelectedText = value.GetString(SettingKeys.HatRightKey);
            }
        }
    }
}

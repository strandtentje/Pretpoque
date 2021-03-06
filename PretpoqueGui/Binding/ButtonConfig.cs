﻿using System;
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
    public partial class ButtonConfig : UserControl, IControllerComponentConfig
    {
        private int buttonIndex;

        public ButtonConfig(int buttonIndex)
        {
            InitializeComponent();
            this.buttonIndex = buttonIndex;

            KeyList.PrimeComboBox(KeybindSelector);
        }

        public void UpdateState(JoystickState state)
        {
            this.ButtonActive.Checked = state.GetButton((JoystickButton)this.buttonIndex) == OpenTK.Input.ButtonState.Pressed;
        }

        public Settings Settings {
            get
            {
                Settings settings = new Settings();
                
                settings[SettingsKeys.ButtonKey] = this.KeybindSelector.Text;

                return settings;
            }
            set
            {
                if (value.Has(SettingsKeys.ButtonKey))
                {
                    this.KeybindSelector.SelectedText = value.GetString(SettingsKeys.ButtonKey);
                }
            }
        }

        public string ConfigName
        {
            get { return "button" + this.buttonIndex; }
        }
    }
}

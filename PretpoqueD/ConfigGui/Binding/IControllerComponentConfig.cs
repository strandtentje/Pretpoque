using BorrehSoft.Utensils.Collections.Settings;
using OpenTK.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PretpoqueD
{
    interface IControllerComponentConfig
    {
        string ConfigName { get; }

        void UpdateState(JoystickState state);

        Settings Settings { get; set; }
    }
}

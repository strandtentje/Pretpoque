using PretpoqueCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput.Native;
using NamedKey = System.Collections.Generic.KeyValuePair<string, PretpoqueCommon.ExtendedVirtualKeyCode>;

namespace PretpoqueGui
{
    static class KeyList
    {
        static List<NamedKey> keys = null;

        public static List<NamedKey> GetAll()
        {
            if (keys == null)
            {
                keys = new List<NamedKey>();

                foreach (ExtendedVirtualKeyCode item in Enum.GetValues(typeof(ExtendedVirtualKeyCode)))
                {
                    keys.Add(new NamedKey(
                        Enum.GetName(typeof(ExtendedVirtualKeyCode), item),
                        item
                    ));
                }
            }

            return keys;
        }

        public static void PrimeComboBox(ComboBox comboBox)
        {            
            comboBox.DisplayMember = "Key";
            foreach (var item in GetAll())
            {
                comboBox.Items.Add(item);
            }
        }
    }
}

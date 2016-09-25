using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NamedKey = System.Collections.Generic.KeyValuePair<string, System.Windows.Forms.Keys>;

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

                foreach (Keys item in Enum.GetValues(typeof(Keys)))
                {
                    keys.Add(new NamedKey(
                        Enum.GetName(typeof(Keys), item),
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

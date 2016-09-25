using System;
using System.Collections.Generic;
using System.Text;
using ThreadTimer = System.Threading.Timer;
using System.Windows.Forms;
using System.Diagnostics;

namespace PretpoqueD
{
    class Bootstrapper
    {
        static void Main(string[] args)
        {
            ControllerPicker picker = new ControllerPicker();

            if (picker.ShowDialog() != DialogResult.OK) return;

            ControllerBinder binder = new ControllerBinder(picker.SelectedControllerIndex);

            if (binder.ShowDialog() != DialogResult.OK) return;


        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using ThreadTimer = System.Threading.Timer;
using System.Windows.Forms;
using System.Diagnostics;
using BorrehSoft.Utensils.Log;
using WindowsInput;

namespace PretpoqueD
{
    class Bootstrapper
    {
        static int[] mouseXAxisMultipliers;
        static int[] mouseYAxisMultipliers;
        static int[] lowerTriggers;
        static int[] upperTriggers;
        static Keys[] lowerTriggerKeys;
        static Keys[] upperTriggerKeys;
        static Keys[] buttonKeys;
        static Keys[] hatLeftKeys;
        static Keys[] hatRightKeys;
        static Keys[] hatUpKeys;
        static Keys[] hatDownKeys;

        static void Main(string[] args)
        {
            string time = DateTime.Now.ToString("yyyy-MM-dd--THHmmsszz");
            Secretary logger = new Secretary(time + ".log");
            logger.globVerbosity = 10;
            logger.ReportHere(0, "Logfile Opened");
            
            ControllerPicker picker = new ControllerPicker();

            if (picker.ShowDialog() != DialogResult.OK) return;

            ControllerBinder binder = new ControllerBinder(picker.SelectedControllerIndex);

            if (binder.ShowDialog() != DialogResult.OK) return;

            ThreadTimer pollThread = new ThreadTimer(poller, null, 0, 10);
        }

        static void poller(object none)
        {

        }
    }
}

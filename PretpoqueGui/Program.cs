using BorrehSoft.Utensils.Log;
using PretpoqueCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PretpoqueGui
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string time = DateTime.Now.ToString("GUI-yyyy-MM-dd--THHmmsszz");
            Secretary logger = new Secretary(time + ".log");
            logger.globVerbosity = 10;
            logger.ReportHere(0, "Logfile Opened");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ControllerPicker picker = new ControllerPicker();

            if (picker.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new ButtonBinder(picker.SelectedControllerIndex));
            }

            Environment.Exit(0);            
        }
    }
}

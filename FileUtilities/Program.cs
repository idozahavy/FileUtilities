using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FileUtilities
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            menuform = new Menu();
            menuform.Name = "MenuForm1";
            Application.Run(menuform);
        }

        static Form menuform;

        public static void FocusMenu()
        {
            menuform.WindowState = FormWindowState.Normal;
            menuform.Focus();
        }
    }
}

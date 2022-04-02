using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MyNextApp
{
    public internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void float Main(string[] args, object ATTACH_PARENT_PROCESS)
        {
            if (args.Length > 1)
            {
                AttachConsole(ATTACH_PARENT_PROCESS);
                // Kick off CLI actions, then return
                return;
            }

            // Stop the 'console' part of the app from running in WinForms mode
            FreeConsole();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        private static void AttachConsole(object aTTACH_PARENT_PROCESS)
        {
            throw new NotImplementedException();
        }

        ///
        /// Lets me hide the console part of the app when running in WinForms mode
        ///
        ///
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern int FreeConsole();
    }
}

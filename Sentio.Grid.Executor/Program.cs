using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Sentio.Grid.Executor
{
    static class Program
    {
        public static MainWIndow GridConsole;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GridConsole = new MainWIndow();
            Application.Run(GridConsole);
        }
    }
}

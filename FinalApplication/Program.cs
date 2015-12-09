using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalApplication
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // I think it would be best to leave these two lines active.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainMenuForm());

            //  Create Controller
            Controller controller = new Controller();

            //  Start program at greeting screen
            controller.DisplayGreetingScreen();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalApplication
{
    public class Controller
    {
        #region [ FIELDS ]


        #endregion

        #region [ PROPERTIES ]


        #endregion

        #region [ METHODS ]

        //  Start Greeting Screen Form
        public void DisplayGreetingScreen()
        { 
            Application.Run(new GreetingForm(this));
        }

        //  Exit the Application
        public void CloseApplication()
        {
            Application.Exit();
        }

        //  Start the Main Menu Form
        public void DisplayMainMenyScreen()
        {

        }
        

        #endregion

        #region [ CONSTRUCTORS ]

        //  Default constructor
        public Controller()
        {

        }

        #endregion
    }
}

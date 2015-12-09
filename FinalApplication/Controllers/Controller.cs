using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalApplication
{
    class Controller
    {
        #region [ FIELDS ]


        #endregion

        #region [ PROPERTIES ]


        #endregion

        #region [ METHODS ]

        //  Start Main Menu Form
        public void DisplayGreetingScreen()
        { 
            Application.Run(new GreetingForm());
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

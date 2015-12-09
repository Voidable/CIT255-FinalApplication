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

        private Form _currentForm;

        #endregion

        #region [ PROPERTIES ]


        #endregion

        #region [ METHODS ]

        //  Start Greeting Screen Form
        public void DisplayGreetingScreen()
        {
            if (_currentForm != null)
            {
                _currentForm.Hide();
                _currentForm = new GreetingForm(this);
                _currentForm.Show();
            }
        }

        //  Exit the Application
        public void CloseApplication()
        {
            Application.Exit();
        }

        //  Start the Main Menu Form
        public void DisplayMainMenuScreen()
        {
            if (_currentForm != null)
            {
                _currentForm.Hide();
                _currentForm = new MainMenuForm(this);
                _currentForm.Show();
            }
        }


        #endregion

        #region [ CONSTRUCTORS ]

        //  Default constructor
        public Controller()
        {
            _currentForm = new GreetingForm(this);
            Application.Run(_currentForm);
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalApplication
{
    public partial class GreetingForm : Form
    {


        #region [ FIELDS ]

        //  Holder to reference its controller
        private Controller _controller;

        private bool closeApplication = true;

        #endregion

        #region [ PROPERTIES ]


        #endregion

        #region [ METHODS ]

        /// <summary>
        /// Button to Exit the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            _controller.CloseApplication();
        }

        /// <summary>
        /// Button to continue to main menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnContinue_Click(object sender, EventArgs e)
        {
            _controller.DisplayMainMenuScreen();
            closeApplication = false;
        }

        #endregion

        #region [ CONSTRUCTORS ]

        public GreetingForm()
        {
            InitializeComponent();
        }

        public GreetingForm(Controller controller)
        {
            InitializeComponent();
            _controller = controller;
        }



        #endregion

        private void GreetingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (closeApplication)
            {
                Application.Exit();
            }
        }
    }
}

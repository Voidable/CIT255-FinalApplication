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
    public partial class MainMenuForm : Form
    {
        private Controller _controller;

        public MainMenuForm()
        {
            InitializeComponent();
        }

        // Button to exit the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            _controller.DisplayGreetingScreen();
        }

        public MainMenuForm(Controller controller)
        {
            InitializeComponent();
            _controller = controller;
        }
    }
}

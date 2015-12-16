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
        #region [ FIELDS ]

        private Controller _controller;
        private List<Game> _games;
        private bool allowEdits = false;
        private bool closeApplication = true;

        #endregion

        #region [ CONSTRUCTORS ]

        /// <summary>
        /// Default constructor. DO NOT USE!
        /// </summary>
        public MainMenuForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor, holds reference to the controller.
        /// </summary>
        /// <param name="controller"></param>
        public MainMenuForm(Controller controller)
        {
            InitializeComponent();

            //  Create reference to controller
            _controller = controller;

            //  Update the list of games
            _games = _controller.GetGamesList();

            // Bind the list of games to the listbox for display
            lbxMain.DataSource = _games;

            //  Bind the ESRB Ratings to the combobox
            cmbRating.DataSource = Enum.GetValues(typeof(Game.ESRBRatings));

            //  Fireoff the selection change event, to ensure the detail region is populated correctly.
            lbxMain_SelectedIndexChanged(this, EventArgs.Empty);

            //  Make the checkboxes read-only for now
            chbPC.AutoCheck = false;
            chbXB.AutoCheck = false;
            chbPS.AutoCheck = false;

        }
        #endregion

        #region [ BUTTONS ]

        // Button to exit the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            closeApplication = false;
            _controller.DisplayGreetingScreen();
        }

        //  Button to toggle the editing state
        private void btnToggleEdit_Click(object sender, EventArgs e)
        {
            //  Enable editing
            if (allowEdits == false)
            {
                allowEdits = true;
                btnToggleEdit.Text = "Disable Editing";

                EnableDetailEditing();
                btnSubmitEdit.Enabled = true;

                //  Disable the other buttons
                btnCreate.Enabled = false;
                btnDelete.Enabled = false;
            }

            //  Disable editing
            else
            {
                allowEdits = false;
                btnToggleEdit.Text = "Enable Editing";

                DisableDetailEditing();
                btnSubmitEdit.Enabled = false;

                //  Enable the other buttons
                btnCreate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        //  Button to submit the edits to the currently selected record
        private void btnSubmitEdit_Click(object sender, EventArgs e)
        {
            if (lbxMain.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a record");
                return;
            }

            //  Get the ID of the currently selected region
            int ID = ((Game)lbxMain.SelectedItem).ID;

            //  Create new Game based on the current detail controls
            Game game = new Game();

            //  Validation
            try
            {
                game.ID = int.Parse(txbID.Text);
            }
            catch
            {
                MessageBox.Show("It does not appear that the ID is proper format.");
                return;
            }
            if (ID != int.Parse(txbID.Text) && _games.Any(g => g.ID == int.Parse(txbID.Text)))
            {
                MessageBox.Show("The ID you have entered is in use by another record");
                return;
            }


            if (txbName.Text.Trim().Count() == 0)
            {
                MessageBox.Show("Name cannot be blank");
                return;
            }
            else
                game.Name = txbName.Text;


            if (txbDev.Text.Trim().Count() == 0)
            {
                MessageBox.Show("Developer cannot be blank");
                return;
            }
            else
                game.Developer = txbDev.Text;


            if (txbPub.Text.Trim().Count() == 0)
            {
                MessageBox.Show("Publisher cannot be blank");
                return;
            }
            else
                game.Publisher = txbPub.Text;

            try
            {
                game.ContentRating = (Game.ESRBRatings)cmbRating.SelectedValue;
            }
            catch 
            {
                MessageBox.Show("I honest have no Idea how the combobox would break.");
                return;
            }


            try
            {
                game.ReleaseDate = DateTime.Parse(txbRelease.Text);
            }
            catch
            {
                MessageBox.Show("Unable to parse the release date, check the formating.");
                return;
            }


            try
            {
                game.UnitsSold = double.Parse(txbSold.Text.Substring(0, txbSold.Text.Length));
            }
            catch
            {
                MessageBox.Show("Unable to parse the Units Sold, check the formating.");
                return;
            }

            //  Check boxes should be impossible to break
            game.AvailableOnPC = chbPC.Checked;
            game.AvailableOnXB = chbXB.Checked;
            game.AvailableOnPS = chbPS.Checked;

            //  Call controller to update it
            _controller.UpdateGame(ID, game);

            UpdateRecordList();

        }

        //  Button to create new record
        private void btnCreate_Click(object sender, EventArgs e)
        {
            //  Clear the detail region, prompting user to enter values
            ClearDetailRegion("Enter the Values for the new record.");

            //  Enable Editing
            EnableDetailEditing();

            //  Disable itself - only way to continue is exit and submit new record
            btnCreate.Enabled = false;

            //  Disable other buttons
            btnDelete.Enabled = false;
            btnToggleEdit.Enabled = false;

            //  Enable Submit button
            btnSubmitRecord.Enabled = true;
            
        }

        //  Button to Submit new record
        private void btnSubmitRecord_Click(object sender, EventArgs e)
        {
            //  Create new Game based on the current detail controls
            Game game = new Game();

            //  Validation
            try
            {
                game.ID = int.Parse(txbID.Text);
            }
            catch
            {
                MessageBox.Show("It does not appear that the ID is proper format.");
                return;
            }
            if (_games.Count(g => g.ID == int.Parse(txbID.Text)) > 0)
            {
                MessageBox.Show("The ID you have entered is in use by another record!");
                return;
            }

            if (txbName.Text.Trim().Count() == 0)
            {
                MessageBox.Show("Name cannot be blank");
                return;
            }
            else
                game.Name = txbName.Text;


            if (txbDev.Text.Trim().Count() == 0)
            {
                MessageBox.Show("Developer cannot be blank");
                return;
            }
            else
                game.Developer = txbDev.Text;


            if (txbPub.Text.Trim().Count() == 0)
            {
                MessageBox.Show("Publisher cannot be blank");
                return;
            }
            else
                game.Publisher = txbPub.Text;

            try
            {
                game.ContentRating = (Game.ESRBRatings)cmbRating.SelectedValue;
            }
            catch
            {
                MessageBox.Show("I honest have no Idea how the combobox would break.");
                return;
            }


            try
            {
                game.ReleaseDate = DateTime.Parse(txbRelease.Text);
            }
            catch
            {
                MessageBox.Show("Unable to parse the release date, check the formating.");
                return;
            }


            try
            {
                game.UnitsSold = double.Parse(txbSold.Text.Substring(0, txbSold.Text.Length));
            }
            catch
            {
                MessageBox.Show("Unable to parse the Units Sold, check the formating.");
                return;
            }

            //  Check boxes should be impossible to break
            game.AvailableOnPC = chbPC.Checked;
            game.AvailableOnXB = chbXB.Checked;
            game.AvailableOnPS = chbPS.Checked;

            //  Call controller to Create it
            _controller.InsertGame(game);

            UpdateRecordList();

            //  Enable other buttons
            btnDelete.Enabled = true;
            btnToggleEdit.Enabled = true;

            //  Disable Submit button
            btnSubmitRecord.Enabled = false;
        }

        //  Button to Delete a record
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbxMain.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a record");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure you want to delete the selected record?!","Confirm Deletion!", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
            //  Get the ID of the currently selected record
            int ID = ((Game)lbxMain.SelectedItem).ID;

            //  Call the controller to delete it
            _controller.DeleteRecord(ID);

            UpdateRecordList();
            }


        }
        #endregion

        #region [ FORM EVENTS ]

        private void MainMenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (closeApplication)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Event fired when the Listbox displays something. This allows us to base Game objects to the listbox and get them back out, whilst still displaying the formated string.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbxMain_Format(object sender, ListControlConvertEventArgs e)
        {
            //  Get the game thats being converted.
            Game g = e.ListItem as Game;

            //  Get the games summary string.
            string s = g.SummaryString();

            //  Enter the summary string in place of the default ToString()
            e.Value = s;
        }

        /// <summary>
        /// Event fired when the selection changes in the box. Updates the detail region
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbxMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxMain.SelectedIndex >= 0)
            {
                UpdateDetailRegion((Game)lbxMain.SelectedItem);
            }
        }

        #endregion

        #region [ METHODS ]

        /// <summary>
        /// Refreshes the Listbox
        /// </summary>
        private void UpdateRecordList()
        {
            // Update the list of games
            _games = _controller.GetGamesList();

            //  Rebind the list, to make the listbox refresh.
            lbxMain.DataSource = null;
            lbxMain.DataSource = _games;
        }

        /// <summary>
        /// Method to update the Detail region of the form
        /// </summary>
        /// <param name="game"></param>
        private void UpdateDetailRegion(Game game)
        {
            txbID.Text = game.ID.ToString();
            txbName.Text = game.Name;
            txbDev.Text = game.Developer;
            txbPub.Text = game.Publisher;
            txbRelease.Text = game.ReleaseDate.ToShortDateString();
            txbSold.Text = game.UnitsSold.ToString();
            cmbRating.SelectedItem = game.ContentRating;
            txbRating.Text = game.ContentRating.ToString();
            chbPC.Checked = game.AvailableOnPC;
            chbXB.Checked = game.AvailableOnXB;
            chbPS.Checked = game.AvailableOnPS;
        }

        /// <summary>
        /// Clears the Detail region, with string input for the name textbox.
        /// </summary>
        /// <param name="nameBox"></param>
        private void ClearDetailRegion(string nameBox)
        {
            txbID.Text = "";
            txbName.Text = nameBox;
            txbDev.Text = "";
            txbPub.Text = "";
            txbRelease.Text = "";
            txbSold.Text = "";
            cmbRating.SelectedItem = Game.ESRBRatings.Everyone;
            txbRating.Text = "";
            chbPC.Checked = false;
            chbXB.Checked = false;
            chbPS.Checked = false;
        }

        /// <summary>
        /// Method to enable editing in the detail region.
        /// </summary>
        private void EnableDetailEditing()
        {
            txbID.ReadOnly = false;
            txbName.ReadOnly = false;
            txbDev.ReadOnly = false;
            txbPub.ReadOnly = false;
            txbRelease.ReadOnly = false;
            txbSold.ReadOnly = false;

            //  Crouching combobox, hidden read-only textbox
            cmbRating.Visible = true;
            txbRating.Visible = false;

            chbPC.AutoCheck = true;
            chbXB.AutoCheck = true;
            chbPS.AutoCheck = true;
        }

        /// <summary>
        /// Method to disable editing in the detail region.
        /// </summary>
        private void DisableDetailEditing()
        {
            txbID.ReadOnly = true;
            txbName.ReadOnly = true;
            txbDev.ReadOnly = true;
            txbPub.ReadOnly = false;
            txbRelease.ReadOnly = true;
            txbSold.ReadOnly = true;

            //  Crouching combobox, hidden read-only textbox
            cmbRating.Visible = false;
            txbRating.Visible = true;

            chbPC.AutoCheck = false;
            chbXB.AutoCheck = false;
            chbPS.AutoCheck = false;

            //  Reset the detail region, removing uncommited changes
            UpdateDetailRegion((Game)lbxMain.SelectedItem);
        }




        #endregion


    }
}

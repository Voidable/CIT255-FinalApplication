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
        private GameRepository repository;

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

        public List<Game> GetGamesList()
        {
            using (repository = new GameRepository())
            {
                return repository.SelectAllGames();
            }
        }

        public void UpdateGame(int ID, Game game)
        {
            using (repository = new GameRepository())
            {
                repository.UpdateGame(ID, game);
            }
        }

        public void InsertGame(Game game)
        {
            using (repository = new GameRepository())
            {
                repository.InsertGame(game);
            }
        }

        public void DeleteRecord(int ID)
        {
            using (repository = new GameRepository())
            {
                repository.DeleteGame(ID);
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

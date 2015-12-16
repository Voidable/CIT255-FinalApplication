using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Xml;
using System.Xml.Serialization;

namespace FinalApplication
{
    public class GameRepository : IDisposable
    {
        DataSet _games_dSet = new DataSet();
        DataTable _games_dTable = new DataTable();

        public GameRepository()
        {
            //  Read the XML file to the dataset
            ReadGamesFromFile();

            //  Name the Dataset
            _games_dSet.DataSetName = "Games";

            //  Make the DataTable equal the the first table in the DataSet
            _games_dTable = _games_dSet.Tables[0];
        }

        /// <summary>
        /// Method to read the entries from the XML file located in the Datasettings.dataFilePath. Updates _games_dSet.
        /// </summary>
        public void ReadGamesFromFile()
        {
            //  Create an XmlReader object
            XmlReader xmlReader = XmlReader.Create(DataSettings.dataFilePath);

            //  Read data file into DataSet
            _games_dSet.ReadXml(xmlReader);

            //  Close XmlReader
            xmlReader.Close();
        }

        /// <summary>
        /// write the dataset to the xml file
        /// </summary>
        public void WriteGamesToFile()
        {
            //  Create a XmlWriterSettings object to set the writing method
            XmlWriterSettings xmlSettings = new XmlWriterSettings();
            xmlSettings.Indent = true;
            xmlSettings.IndentChars = "\t";

            //  Create XmlWrtier object
            XmlWriter xmlWriter = XmlWriter.Create(DataSettings.dataFilePath, xmlSettings);

            //  Write DataSet to data file
            _games_dSet.WriteXml(xmlWriter);

            //  Close DataWrtier
            xmlWriter.Close();
        }

        /// <summary>
        /// Returns a list of all Games in the repository.
        /// </summary>
        /// <returns></returns>
        public List<Game> SelectAllGames()
        {
            List<Game> games = new List<Game>();

            foreach (DataRow game in _games_dTable.Rows)
            {
                games.Add(new Game
                {
                    ID = int.Parse(game["ID"].ToString()),
                    Name = game["Name"].ToString(),
                    Developer = (game["Developer"].ToString()),
                    Publisher = (game["Publisher"].ToString()),
                    ReleaseDate = DateTime.Parse(game["Release"].ToString()),
                    ContentRating = (Game.ESRBRatings)Enum.Parse(typeof(Game.ESRBRatings), (game["ContentRating"].ToString()), true),
                    UnitsSold = double.Parse(game["UnitsSold"].ToString()),
                    AvailableOnPC = bool.Parse(game["PlatformPC"].ToString()),
                    AvailableOnXB = bool.Parse(game["PlatformXB"].ToString()),
                    AvailableOnPS = bool.Parse(game["PlatformPS"].ToString())

                });
            }

            return games;
        }

        /// <summary>
        /// Adds a game to the list.
        /// </summary>
        /// <param name="game"></param>
        public void InsertGame(Game game)
        {
            fillRow(_games_dTable, game.ID, game.Name, game.Developer, game.Publisher, game.ContentRating, game.ReleaseDate, game.UnitsSold, game.AvailableOnPC, game.AvailableOnXB, game.AvailableOnPS);
        }

        /// <summary>
        /// Returns a Game based on ID, or fails if it finds none or multiple.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Game SelectByID(int id)
        {
            Game game;
            DataRow[] games;

            //  Get array of games with matching ID
            games = _games_dTable.Select("ID = " + id.ToString());

            //  No matching Games
            if (games.Count() <= 0)
            {
                throw new Exception("No games with ID found");
            }

            //  Returns multiple Games
            else if (games.Count() > 1)
            {
                throw new Exception("More than one game is found");
            }

            //  A single Game is returned.
            else
            {
                game = new Game(

                    int.Parse(games[0]["ID"].ToString()),
                    games[0]["Name"].ToString(),
                    games[0]["Developer"].ToString(),
                    games[0]["Publisher"].ToString(),
                    (Game.ESRBRatings)Enum.Parse(typeof(Game.ESRBRatings), (games[0]["ContentRating"].ToString())),
                    DateTime.Parse(games[0]["Release"].ToString()),
                    double.Parse(games[0]["UnitsSold"].ToString()),
                    bool.Parse(games[0]["PlatformPC"].ToString()),
                    bool.Parse(games[0]["PlatformXB"].ToString()),
                    bool.Parse(games[0]["PlatformPS"].ToString())
                    );
            }

            return game;
        }

        /// <summary>
        /// Delete a game.
        /// </summary>
        /// <param name="ID"></param>
        public void DeleteGame(int id)
        {
            DataRow[] games;

            //  Get array of games with matching ID
            games = _games_dTable.Select("ID = " + id.ToString());

            //  No matching Games
            if (games.Count() <= 0)
            {
                throw new Exception("No games with ID found");
            }

            //  Returns multiple Games
            else if (games.Count() > 1)
            {
                throw new Exception("More than one game is found");
            }

            //  A single Game is returned.
            else
            {
                //  Delete it.
                _games_dTable.Rows.Remove(games[0]);
            }
        }

        /// <summary>
        /// Update a game with a given ID
        /// </summary>
        /// <param name="game"></param>
        public void UpdateGame(int ID, Game game)
        {
            DataRow[] games;

            //  Get array of games with matching ID
            games = _games_dTable.Select("ID = " + ID.ToString());

            //  No matching Games
            if (games.Count() <= 0)
            {
                throw new Exception("No games with ID found");
            }

            //  Returns multiple Games
            else if (games.Count() > 1)
            {
                throw new Exception("More than one game is found");
            }

            //  A single Game is returned.
            else
            {
                games[0]["ID"] = game.ID.ToString();
                games[0]["Name"] = game.Name;
                games[0]["Developer"] = game.Developer;
                games[0]["Publisher"] = game.Publisher;
                games[0]["ContentRating"] = game.ContentRating.ToString();
                games[0]["Release"] = game.ReleaseDate.ToString();
                games[0]["UnitsSold"] = game.UnitsSold.ToString();
                games[0]["PlatformPC"] = game.AvailableOnPC;
                games[0]["PlatformXB"] = game.AvailableOnXB;
                games[0]["PlatformPS"] = game.AvailableOnPS;
            }
        }

        /// <summary>
        /// Generic query to return based on expression.
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public List<Game> QueryByExpression(string expression)
        {
            List<Game> Games = new List<Game>();
            DataRow[] drGames = _games_dTable.Select(expression);
            return Games;
        }

        /// <summary>
        /// Query that returns a list of games base on the name.
        /// </summary>
        /// <param name="name">Name to search against.</param>
        /// <param name="isExact">Search for an exact match, or FALSE to find anything containing the input name.</param>
        /// <returns></returns>
        public List<Game> QueryByName(string name, bool isExact)
        {
            List<Game> Games = new List<Game>();
            foreach (Game g in QueryByExpression(""))
            {
                if (isExact)
                {
                    if (g.Name.ToLower() == name.ToLower())
                    {
                        Games.Add(g);
                    }

                }
                else
                {
                    if (g.Name.ToLower().Contains(name.ToLower()))
                    {
                        Games.Add(g);
                    }
                }
            }
            return Games;
        }

        /// <summary>
        /// Add a row to the DataTable containing all the cell values.
        /// </summary>
        /// <param name="dTable">The Table</param>
        /// <param name="ID">The ID of the entry</param>
        /// <param name="name">The name of the Game</param>
        /// <param name="developer">The developer of the Game</param>
        /// <param name="publisher">The Publisher of the Game</param>
        /// <param name="release">The release date of the Game</param>
        /// <param name="unitsSold">Number of Units sold in millions</param>
        /// <param name="PC">Is the game available on PC</param>
        /// <param name="XB">IS the game available on Xbox</param>
        /// <param name="PS">Is the game available on PlayStation</param>
        private static void fillRow(DataTable dTable,
            int ID,
            string name,
            string developer,
            string publisher,
            Game.ESRBRatings rating,
            DateTime release,
            double unitsSold,
            bool PC, bool XB, bool PS
            )
        {
            DataRow dRow;
            dRow = dTable.NewRow();

            dRow["ID"] = ID;
            dRow["Name"] = name;
            dRow["Developer"] = developer;
            dRow["Publisher"] = publisher;
            dRow["Release"] = release;
            dRow["ContentRating"] = rating;
            dRow["UnitsSold"] = unitsSold;
            dRow["PlatformPC"] = PC;
            dRow["PlatformXB"] = XB;
            dRow["PlatformPS"] = PS;

            dTable.Rows.Add(dRow);
        }

        /// <summary>
        /// Required Dispose method
        /// </summary>
        public void Dispose()
        {
            WriteGamesToFile();
            _games_dSet.Dispose();
        }
    }
}

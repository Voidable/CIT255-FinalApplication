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
    public class GameRepository
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


        public List<Game> SelectAllRuns()
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
            DateTime release,
            Game.ESRBRatings rating,
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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalApplication
{
    /// <summary>
    /// Class to define a video game for storage.
    /// </summary>
    public class Game
    {
        #region [ ENUMS ]

        public enum ESRBRatings
        {
            EarlyChildhood,
            Everyone,
            Everyone10up,
            Teen,
            Mature
        }

        #endregion

        #region [ FIELDS ]

        /// <summary>
        /// ID for the Game's entry in the database.
        /// </summary>
        private int _ID;

        //  String details for the Game
        private string _name;
        private string _developer;
        private string _publisher;

        //  Game's ESRB rating
        private ESRBRatings _contentRating;

        //  Games release date
        private DateTime _releaseDate;

        //  Number of units sold. NOTE: this should be in Millions.
        private double _unitsSold;

        //  What platforms is the game available on, assume all Xbox models and Playstation models are the same.
        private bool _platformPC;
        private bool _platformXB;
        private bool _platformPS;

        #endregion

        #region [ PROPERTIES ]

        /// <summary>
        /// ID for the game's record entry.
        /// </summary>
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        /// <summary>
        /// Title/Name of the Game
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// Developer of the game
        /// </summary>
        public string Developer
        {
            get { return _developer; }
            set { _developer = value; }
        }

        /// <summary>
        /// Publisher of the game
        /// </summary>
        public string Publisher
        {
            get { return _publisher; }
            set { _publisher = value; }
        }

        /// <summary>
        /// The game's ESRB content rating.
        /// </summary>
        public ESRBRatings ContentRating
        {
            get { return _contentRating; }
            set { _contentRating = value; }
        }

        /// <summary>
        /// The game's release date.
        /// </summary>
        public DateTime ReleaseDate
        {
            get { return _releaseDate; }
            set { _releaseDate = value; }
        }

        /// <summary>
        /// The number of units sold, in MILLIONS
        /// </summary>
        public double UnitsSold
        {
            get { return _unitsSold; }
            set { _unitsSold = value; }
        }

        /// <summary>
        /// Was the game released for PC
        /// </summary>
        public bool AvailableOnPC
        {
            get { return _platformPC; }
            set { _platformPC = value; }
        }

        /// <summary>
        /// Was the game released on an XBOX platform.
        /// </summary>
        public bool AvailableOnXB
        {
            get { return _platformXB; }
            set { _platformXB = value; }
        }

        /// <summary>
        /// Was the game released on a Playstation platform.
        /// </summary>
        public bool AvailableOnPS
        {
            get { return _platformPS; }
            set { _platformPS = value; }
        }

        #endregion

        #region [ METHODS ]

        public string SummaryString()
        {
            return string.Format("ID: " + _ID.ToString().PadRight(3) + " Name: " + _name.PadRight(30).Substring(0, 30) + " Developer: " + _developer.PadRight(20).Substring(0,20));
        }


        #endregion

        #region [ CONSTRUCTORS ]

        /// <summary>
        /// Default constructor, instantiates a Generic Game
        /// </summary>
        public Game()
        {
            _ID = 0;

            _name = "The Game";
            _developer = "The Game Makers";
            _publisher = "Publisher of The Game";

            _contentRating = ESRBRatings.Everyone;

            _releaseDate = DateTime.Now;

            _unitsSold = 0.0;

            _platformPC = true;
            _platformXB = true;
            _platformPS = true;
        }

        /// <summary>
        /// Overloaded constructor, allows all values to be set
        /// </summary>
        public Game(int id, string name, string dev, string pub, ESRBRatings rating, DateTime release, double unitsSold, bool PC, bool XB, bool PS)
        {
            _ID = id;

            _name = name;
            _developer = dev;
            _publisher = pub;

            _contentRating = rating;

            _releaseDate = release;

            _unitsSold = unitsSold;

            _platformPC = PC;
            _platformXB = XB;
            _platformPS = PS;
        }

        #endregion
    }
}

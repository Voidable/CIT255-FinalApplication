using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Data;

namespace FinalApplication
{
    public class InitializeDataFile
    {
        public static void AddTestData()
        {
            //  Declare Dataset and DataTable
            DataSet dSet = new DataSet();
            DataTable dTable = new DataTable();

            // Declare columns
            dTable.Columns.Add(new DataColumn("ID", typeof(Int32)));
            dTable.Columns.Add(new DataColumn("Name", typeof(String)));
            dTable.Columns.Add(new DataColumn("Developer", typeof(string)));
            dTable.Columns.Add(new DataColumn("Publisher", typeof(string)));
            dTable.Columns.Add(new DataColumn("Release", typeof(DateTime)));
            dTable.Columns.Add(new DataColumn("ContentRating", typeof(Game.ESRBRatings)));
            dTable.Columns.Add(new DataColumn("UnitsSold", typeof(double)));
            dTable.Columns.Add(new DataColumn("PlatformPC", typeof(bool)));
            dTable.Columns.Add(new DataColumn("PlatformXB", typeof(bool)));
            dTable.Columns.Add(new DataColumn("PlatformPS", typeof(bool)));

            // Add the 10 test data rows
            fillRow(dTable, 1, "The Witcher 3", "CD Project Red", "Namco Bandai Games", DateTime.Parse("5/19/2015"), Game.ESRBRatings.Mature, 4.10, true, true, true);
            fillRow(dTable, 2, "Halo: Combat Evolved", "Bungie", "Microsoft Game Studios", DateTime.Parse("11/14/2001"), Game.ESRBRatings.Mature, 6.46, true, true, false);
            fillRow(dTable, 3, "Jak and Daxter: The Precursor Legacy", "Naughty Dog", "Sony Computer Entertainment", DateTime.Parse("12/4/2001"), Game.ESRBRatings.Everyone, 3.64, false, false, true);
            fillRow(dTable, 4, "Thief (2014)", "Eidos Montreal", "Square Enix", DateTime.Parse("2/25/2014"), Game.ESRBRatings.Mature, 1.96, true, true, true);
            fillRow(dTable, 5, "Brute Force", "Digital Anvil", "Microsoft Game Studios", DateTime.Parse("5/27/2003"), Game.ESRBRatings.Mature, 0.83, false, true, false);
            fillRow(dTable, 6, "Ratchet & Clank", "Insomniac", "Sony Computer Entertainment", DateTime.Parse("11/7/2002"), Game.ESRBRatings.Teen, 3.33, false, false, true);
            fillRow(dTable, 7, "The Elder Scrolls V: Skyrim", "Bethesda Softworks", "Bethesda Softworks", DateTime.Parse("11/11/2011"), Game.ESRBRatings.Mature, 18.67, true, true, true);
            fillRow(dTable, 8, "Dark Void", "Airtight Games", "Capcom", DateTime.Parse("1/19/2010"), Game.ESRBRatings.Teen, 0.67, true, true, true);
            fillRow(dTable, 9, "Mirror's Edge", "Square Enix", "Electronic Arts", DateTime.Parse("11/11/2008"), Game.ESRBRatings.Teen, 1.36, true, true, true);
            fillRow(dTable, 10, "Papers, please", "3909", "3909", DateTime.Parse("8/8/2013"), Game.ESRBRatings.Teen, 1.25, true, false, false);

            // Add dataTable to dataSet, give name
            dSet.Tables.Add(dTable);
            dSet.Tables[0].TableName = "Game";

            // Name dataSet
            dSet.DataSetName = "Games";

            // create a XmlWriterSettings object to set the writing method
            XmlWriterSettings xmlSettings = new XmlWriterSettings();
            xmlSettings.Indent = true;
            xmlSettings.IndentChars = "\t";

            // create an XMLWriter
            XmlWriter xmlWriter = XmlWriter.Create(DataSettings.dataFilePath, xmlSettings);

            //  Write table to xml file
            dSet.WriteXml(xmlWriter);

            //  Close xmlwriter
            xmlWriter.Close();
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

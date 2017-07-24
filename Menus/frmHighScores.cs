using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AS_SSD_Coursework.Menus
{
    public partial class frmHighScores : Form
    {
        List<HighScoreRecord> highRecordRows = new List<HighScoreRecord>();
        public frmHighScores()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void frmHighScores_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(FilePaths.HIGHSCORES);
            //read each line until the one with the _statName appears and get statValue
            string currentLine;
            while ((currentLine = sr.ReadLine()) != null)
            {
                //grab the highscore and add to listBox
                //using a try catch in case the score string cannot be converted
                try
                {
                    highRecordRows.Add(new HighScoreRecord(currentLine.Split('>')[0], Convert.ToUInt64(currentLine.Split('>')[1])));
                }
                catch (Exception ex)
                {

                    Console.WriteLine("Unable to convert score string to int: {0}", ex.Message);
                }
            }
            //sort the highscore records and display in the list box best player first
            List<HighScoreRecord> sortedList = highRecordRows.OrderByDescending(o => o.Score).ToList();
            highRecordRows.Clear();
            foreach (HighScoreRecord item in sortedList)
                listHighScores.Items.Add(item.ToString());
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    public class HighScoreRecord
    {
        public string PlayerName { get; private set; }
        public ulong Score { get; private set; }
        public HighScoreRecord(string playerName, ulong score)
        {
            this.PlayerName = playerName;
            this.Score = score;
        }

        //override default ToString() and replace with score printout
        public override string ToString()
        {
            return string.Format("{0} - {1}", PlayerName, Score);
        }
    }
}

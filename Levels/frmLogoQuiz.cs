using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS_SSD_Coursework.Levels
{
    public partial class frmLogoQuiz : Form
    {
        private int score = 0;
        private int secondsTaken = 0;
        private int minutesTaken = 0;
        public bool levelReplay = false;

        public frmLogoQuiz()
        {
            InitializeComponent();
            this.CenterToScreen();
            FormManager.Level1 = this;
            //start timer
            timerLevel1.Start();
        }
        public frmLogoQuiz(bool Replay)
        {
            InitializeComponent();
            this.CenterToScreen();
            FormManager.Level1 = this;
            //start timer
            timerLevel1.Start();
            levelReplay = Replay;
        }
        private void CheckScoreAddBonus()
        {
            timerLevel1.Stop();
            if (txtBT.Text.ToLower() == "bt")
                score += 100;
            if (txtLego.Text.ToLower() == "lego")
                score += 100;
            if (txtSkype.Text.ToLower() == "skype")
                score += 100;
            if (txtVW.Text.ToLower() == "vw" || txtVW.Text.ToLower() == "volkswagen")
                score += 100;

            //add score bonus depending on time and show player their score
            //less than 30 seconds score * 1.5
            if (minutesTaken == 0 && secondsTaken < 30)
            {
                score *= 2;
                lblScore.Text = string.Format("That was quick x2 bonus! Score {0}", score);
            }
            //more than 30secs less than 1 min score * 1.25
            else if (minutesTaken == 0 && (secondsTaken > 30 && secondsTaken < 60))
            {
                score = (int)Math.Round(score * 1.25, 0);
                lblScore.Text = string.Format("Not bad x1.25 bonus! Score {0}", score);
            }
            else
            {
                lblScore.Text = string.Format("You scored {0}, you can do better!", score);
            }
        }
        private void txtSubmitScore_Click(object sender, EventArgs e)
        {
            CheckScoreAddBonus();
            if (levelReplay == false)
            {
                //add score to the Player static Class and Player Stats
                Player.currentScore += score;
                //begin transistion to level 2
                Player.currentLevel = 2;
                //update file stats
                StatWriter sw = new StatWriter(FilePaths.PLAYER_STATS);
                sw.WriteStat("Score", Player.currentScore.ToString());
                sw.WriteStat("Level", Player.currentLevel.ToString());
                sw.WriteStat("Leve1Score", score.ToString());
            }

            //wait 3 seconds for the player to see their score before going to level 2
            Methods.GameSleep(3000);
            //goto Level2 only if the level isn't being replayed
            if (levelReplay == false)
            {
                frmQuestionnaire Level2 = new frmQuestionnaire();
                this.Hide();
                Level2.Show();

                //handle closing
                Level2.FormClosing += (s, args) => this.Close();
            }
            else
                //else just exit out of level
                this.Close();
        }
        private void timerLevel1_Tick(object sender, EventArgs e)
        {
            secondsTaken++;
            //if the modulus (remainder) of 60 is 0 ie 1 min add minute
            if(secondsTaken % 60 == 0)
            {
                //60 == 1 min
                minutesTaken++;
                //reset seconds back to zero to count to 60 again
                secondsTaken = 0;
            }

            if (secondsTaken < 10)
            {
                //add extra 0 to textbox ie 0:1 becomes 0:01 looks better
                lblTimeTaken.Text = string.Format("{0}:0{1}", minutesTaken, secondsTaken);
            }
            else
            {
                lblTimeTaken.Text = string.Format("{0}:{1}", minutesTaken, secondsTaken);
            }
        }    
    }
}

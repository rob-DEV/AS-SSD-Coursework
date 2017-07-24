using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS_SSD_Coursework.Levels
{
    public partial class frmDragGame : Form
    {
        private int score = 0;
        private int secondsTaken = 0;
        private int minutesTaken = 0;
        private List<int> planetXPositions = new List<int>() { 16, 107, 199, 289, 380, 472, 564, 656 };
        string selectedPlanet = "";
        public bool levelReplay = false;

        public frmDragGame()
        {
            InitializeComponent();
            this.CenterToScreen();
            FormManager.Level3 = this;
            timerLevel3.Start();
        }
        public frmDragGame(bool Replay)
        {
            InitializeComponent();
            this.CenterToScreen();
            FormManager.Level3 = this;
            timerLevel3.Start();
            levelReplay = Replay;
        }

        private void CheckScoreAddBonus()
        {
            //add score bonus depending on time and show player their score
            //less than 30 seconds score * 1.5
            if (score > 0)
            {
                if (minutesTaken == 0 && secondsTaken < 15)
                {
                    score *= 2;
                    lblScore.Text = string.Format("That was quick x2 bonus! Score {0}", score);
                }
                //more than 30secs less than 1 min score * 1.25
                else if (minutesTaken == 0 && (secondsTaken > 15 && secondsTaken < 20))
                {
                    score = (int)Math.Round(score * 1.25, 0);
                    lblScore.Text = string.Format("Not bad x1.25 bonus! Score {0}", score);
                }
                else
                {
                    lblScore.Text = string.Format("You scored {0}, you can do better!", score);
                }
            }
            else
            {
                lblScore.Text = string.Format("You scored nothing, have another go!", score);
            }
        }
        private void frmDragGame_Load(object sender, EventArgs e)
        {
            //assign planet x positons randomly
            Random rand = new Random();
            PictureBox[] planets = new PictureBox[] { picEarth, picJupiter, picMars, picMercury, picNeptune, picSaturn, picUranus, picVenus };
            foreach(PictureBox item in planets)
            {
                int posY = rand.Next(0, planetXPositions.Count - 1);
                item.Location = new Point(planetXPositions[posY], 230);
                planetXPositions.RemoveAt(posY);
            }
            //allow this question mark planets to be droppable
            picPlanet1.AllowDrop = true;
            picPlanet2.AllowDrop = true;
            picPlanet3.AllowDrop = true;
            picPlanet4.AllowDrop = true;
            picPlanet5.AllowDrop = true;
            picPlanet6.AllowDrop = true;
            picPlanet7.AllowDrop = true;
            picPlanet8.AllowDrop = true;
        }

        private void timerLevel3_Tick(object sender, EventArgs e)
        {
            //gameTimer
            secondsTaken++;
            //if the modulus (remainder) of 60 is 0 ie 1 min add minute
            if (secondsTaken % 60 == 0)
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

        private void Planet_MouseDown(object sender, MouseEventArgs e)
        {
            //each planets mouse down event runs this          
            PictureBox pb = sender as PictureBox;
            //this identifies the planet that has been clicked on tag
            selectedPlanet = pb.Tag.ToString();
            pb.DoDragDrop(pb.Image, DragDropEffects.Copy);
        }

        private void PlanetPlaceHolder_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void PlanetPlaceHolder_DragDrop(object sender, DragEventArgs e)
        {
            //indentify box dropped in
            PictureBox pb = sender as PictureBox;
            //lock in user choice
            pb.AllowDrop = false;
            pb.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
            if (pb.Tag.ToString() == selectedPlanet)
                score+=100;
        }

        private void btnCheckScore_Click(object sender, EventArgs e)
        {
            //print out score to user
            CheckScoreAddBonus();
            //delay level change for 3 seconds to allow player to read score
            Methods.GameSleep(3000);
            //only add score to text file if the level isn't being replayed
            if (levelReplay == false)
            {
                //progress to level 4
                Player.currentLevel = 4;
                Player.currentScore += score;
                //update file stats
                StatWriter sw = new StatWriter(FilePaths.PLAYER_STATS);
                sw.WriteStat("Score", Player.currentScore.ToString());
                sw.WriteStat("Leve3Score", score.ToString());
                sw.WriteStat("Level", Player.currentLevel.ToString());
                //submit highscore
                //the snake game score won't count
                StatWriter highScoreWriter = new StatWriter(FilePaths.HIGHSCORES);
                highScoreWriter.WriteStat(Player.playerName, Player.currentScore.ToString());
                frmSnakeGame level4 = new frmSnakeGame();
                this.Hide();
                level4.Show();
                //handle form closing
                level4.FormClosing += (s, args) => this.Close();
            }
            else
            {
                //closes the level dialog
                this.Close();
            }

        }
    }
}

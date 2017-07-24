using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

using AS_SSD_Coursework.Levels;

namespace AS_SSD_Coursework.Menus
{
    public partial class frmMainMenu : Form
    {
        private void SplashScreen()
        {
            Application.Run(new frmLoadingSplashScreen());

        }
        public frmMainMenu()
        {
            //create thread for splash screen
            Thread splashScreenThread = new Thread(new ThreadStart(SplashScreen));
            splashScreenThread.Start();
            //wait until progress bar is loaded to 100% 
            Thread.Sleep(3000);
            InitializeComponent();
            //abort the splashscreen thread
            splashScreenThread.Abort();

            
            this.CenterToScreen();
            //set instances
            FormManager.MainMenu = this;
            //create files if needed
            FilePaths.CreatePlayerFiles();

            //managing avatar
            //if new game hide picturbox
            StatReader statReader = new StatReader(FilePaths.PLAYER_STATS);
            Console.WriteLine("Object found {0}", statReader.ReadStat(1));
            if (statReader.CheckForEmptyFile())
            {
                panPlayerStats.Visible = false;
            }
            else
            {
                picAvatar.Image = Player.GetAvatarFromBinFile();
                lblPlayerName.Text = string.Format("Welcome back, {0}", statReader.ReadStat("Player"));
                lblPlayerScore.Text = string.Format("High Score: {0}", statReader.ReadStat("Score"));
                Player.playerName = statReader.ReadStat("Player");
                try
                {
                    Player.currentLevel = Convert.ToInt32(statReader.ReadStat("Level"));
                    Player.currentScore = Convert.ToInt32(statReader.ReadStat("Score"));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Unable to get score: {0}", ex.Message);
                }
            }
        }
        /// <summary>
        /// Exits the game.
        /// </summary>
        private void btnQuit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "Are You Sure?", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
                this.Close();   
            }
        }

        //menustrip click events
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void aboutTheGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHelp frmHelp = new frmHelp();
            frmHelp.ShowDialog();
        }
        private void leaderboardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Load highscore form
            frmHighScores highScores = new frmHighScores();
            highScores.ShowDialog();
        }

        /// <summary>
        /// Starts either a new game or reads current level from file and continues on
        /// </summary>
        private void btnPlayGame_Click(object sender, EventArgs e)
        {
            StatWriter sr = new StatWriter(FilePaths.PLAYER_STATS);
            //open playerstat file
            StatReader statReader = new StatReader(FilePaths.PLAYER_STATS);

            //this EMPTY text in the file indicates that the game has not been played before
            if (statReader.CheckForEmptyFile())
            {
                //NEW PLAYER SETUP FORM
                frmPlayerSetup playerSetup = new frmPlayerSetup();
                playerSetup.Show();
                this.Hide();

                //handles closing this form so that the application fully exits
                playerSetup.FormClosing += (s, args) => this.Close();
            }
            else
            {
                switch (Player.currentLevel)
                {
                    case 1:
                        //load Level1
                        frmLogoQuiz Level1 = new frmLogoQuiz();
                        Level1.Show();
                        this.Hide();
                        //handle form closing
                        Level1.FormClosing += (s, args) => this.Close();
                        break;
                    case 2:
                        //load frmQuestionaire
                        frmQuestionnaire Level2 = new frmQuestionnaire();
                        Level2.Show();
                        this.Hide();
                        //handle form closing
                        Level2.FormClosing += (s, args) => this.Close();
                        break;
                    case 3:
                        //load frmDragGame
                        frmDragGame Level3 = new frmDragGame();
                        Level3.Show();
                        this.Hide();
                        //handle form closing
                        Level3.FormClosing += (s, args) => this.Close();
                        //handle form closing
                        break;
                    case 4:
                        //load frmSnakeGame
                        frmSnakeGame Level4 = new frmSnakeGame(true);
                        Level4.Show();
                        this.Hide();
                        //handle form closing
                        Level4.FormClosing += (s, args) => this.Close();
                        break;
                }
            }
        }
        //select any of the unlocked levels to replay
        private void btnSelectLevel_Click(object sender, EventArgs e)
        {
            StatReader sr = new StatReader(FilePaths.PLAYER_STATS);
            if (sr.ReadStat(1) == "EMPTY")
            {
                MessageBox.Show("You must play the game first!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                frmLevelChooser chooseLevel = new frmLevelChooser();
                chooseLevel.ShowDialog();
            }
        }
        //load instruction form
        private void btnHelp_Click(object sender, EventArgs e)
        {
            frmHelp frmHelp = new frmHelp();
            frmHelp.ShowDialog();
        }
        //force a new game to start
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            //NEW PLAYER SETUP FORM
            frmPlayerSetup playerSetup = new frmPlayerSetup();
            playerSetup.Show();
            this.Hide();

            //handles closing this form so that the application fully exits
            playerSetup.FormClosing += (s, args) => this.Close();
        }
        //load previous playes scores
        private void btnHighScores_Click(object sender, EventArgs e)
        {
            //Load highscore form
            frmHighScores highScores = new frmHighScores();
            highScores.ShowDialog();
        }

        
    }
}
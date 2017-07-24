using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AS_SSD_Coursework.Levels;

namespace AS_SSD_Coursework.Menus
{
    public partial class frmLevelChooser : Form
    {
        public frmLevelChooser()
        {
            InitializeComponent();
            this.CenterToScreen();
            ShowUnlockedLevels();
        }
        private void ShowUnlockedLevels()
        {
            //read the current level from the stat file and only show the levels
            //that are unlocked. i.e. someone on level 1 cant play level 2, 3, or 4 
            int maxLevelUnlocked = 1;
            try
            {
                maxLevelUnlocked = Convert.ToInt32(new StatReader(FilePaths.PLAYER_STATS).ReadStat("Level"));
            }
            catch (Exception e)
            {

                Console.WriteLine("File Handling / Conversion Error : {0}", e.Message);
            }

            switch (maxLevelUnlocked)
            {
                case 1:
                    panelLevel1.Visible = true;
                    break;
                case 2:
                    panelLevel1.Visible = true;
                    panelLevel2.Visible = true;
                    break;
                case 3:
                    panelLevel1.Visible = true;
                    panelLevel2.Visible = true;
                    panelLevel3.Visible = true;
                    break;
                case 4:
                    panelLevel1.Visible = true;
                    panelLevel2.Visible = true;
                    panelLevel3.Visible = true;
                    panelLevel4.Visible = true;
                    break;
            }
        }
        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ChoosenLevel_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            string buttonName = clickedButton.Name;

            switch (buttonName)
            {
                case "btnPlay1":
                    frmLogoQuiz level1 = new frmLogoQuiz(true);
                    level1.ShowDialog();
                    break;
                case "btnPlay2":
                    frmQuestionnaire level2 = new frmQuestionnaire(true);
                    level2.ShowDialog();
                    level2.levelReplay = true;
                    break;
                case "btnPlay3":
                    frmDragGame level3 = new frmDragGame(true);
                    level3.ShowDialog();
                    level3.levelReplay = true;
                    break;
                case "btnPlay4":
                    frmSnakeGame level4 = new frmSnakeGame(true);
                    level4.ShowDialog();
                    level4.levelReplay = true;
                    break;
            }
        }
    }
}

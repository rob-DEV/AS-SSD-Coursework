using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS_SSD_Coursework.Assets.frmSnakeAssets
{
    public partial class frmSnakeEnd : Form
    {
        public frmSnakeEnd()
        {
            InitializeComponent();
            this.CenterToScreen();
            lblOverallScore.Text = string.Format("Your Score: {0}", Player.currentScore);
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            //hide the snake level
            FormManager.Level4.Hide();
            //cut off the game thread just to be safe
            FormManager.Level4.gameThread.Abort();
            FormManager.MainMenu.Show();
            this.Close();
        }

        private void btnReplay_Click(object sender, EventArgs e)
        {
            //reset level 4 for replaying
            FormManager.Level4.ResetGame();
            this.Close();
        }
    }
}

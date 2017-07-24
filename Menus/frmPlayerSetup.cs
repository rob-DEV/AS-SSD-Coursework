using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using AS_SSD_Coursework.Levels;

namespace AS_SSD_Coursework.Menus
{
    public partial class frmPlayerSetup : Form
    {
        PictureBox Avatar;
        public frmPlayerSetup()
        {
            this.CenterToScreen();
            InitializeComponent();
        }
        private void ValidateData()
        {
            Regex r = new Regex("^[a-zA-Z0-9]+$");
            if (txtName.Text.Length < 1 || !r.IsMatch(txtName.Text) || Avatar == null)
            {
                throw new InvalidDataException();
            }
        }
        //checks that a name has been entered and inserts the stat
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                //CUSTOM EXCEPTION HANDLER FOR DATA ENTRY AND AVATAR
                ValidateData();
                Player.SetupPlayerInitally(txtName.Text, Avatar.Image);
                //Load first game
                frmLogoQuiz Level1 = new frmLogoQuiz();
                //hold instance
                FormManager.Level1 = Level1;
                Level1.Show();
                this.Hide();
                //handles this form closing
                Level1.FormClosing += (s, args) => this.Close();
            }
            catch(InvalidDataException)
            {
                MessageBox.Show("Enter your username \"a-z 0-9\" and select an avatar!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        } 
        private void picAvatar_Click(object sender, EventArgs e)
        {
            //assign avatar
            Avatar = sender as PictureBox;
            //show selected avatar via borderstyle
            Avatar.BorderStyle = BorderStyle.Fixed3D;
        }
        private void btnBrowseForAvatar_Click(object sender, EventArgs e)
        {
            //the player can browse for a photo of themselves
            OpenFileDialog fileBrowser = new OpenFileDialog();
            fileBrowser.Filter = "Image Files (*.jpg) | *.jpg; *.jpeg;";

            if (fileBrowser.ShowDialog() == DialogResult.OK)
            {
                //this image is then convered to an avatar and save to the binary file
                Avatar = new PictureBox();
                Avatar.Image = new Bitmap(fileBrowser.FileName);
            }
            fileBrowser.Dispose();
        }
    }
    /// <summary>
    /// CUSTOM EXCEPTION HANDLER FOR DATA ENTRY
    /// </summary>
    public class InvalidDataException : Exception
    {
        public InvalidDataException():base()
        {
        }
    }
}

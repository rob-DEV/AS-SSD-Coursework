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
    public partial class frmHelp : Form
    {
        public frmHelp()
        {
            InitializeComponent();
            this.CenterToScreen();

            //load about game information from a text file
            using(StreamReader streamReader = new StreamReader(FilePaths.ABOUT_TEXT))
            {
                txtAboutBox.Text = streamReader.ReadToEnd();
            }
        }

        private void btnCloseHelp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

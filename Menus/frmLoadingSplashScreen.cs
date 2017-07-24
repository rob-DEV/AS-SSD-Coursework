using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS_SSD_Coursework.Menus
{
    public partial class frmLoadingSplashScreen : Form
    {
        public frmLoadingSplashScreen()
        {
            InitializeComponent();
            timLoading.Start();
            this.CenterToScreen();
        }

        private void timLoading_Tick(object sender, EventArgs e)
        {
            prgLoading.Increment(5);
        }
    }
}

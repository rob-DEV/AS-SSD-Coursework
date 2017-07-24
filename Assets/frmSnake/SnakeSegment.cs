using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
namespace AS_SSD_Coursework.Assets.frmSnakeAssets
{
    public class SnakeSegment
    {
        //defines snake segments location
        public int xPos { get; set; }
        public int yPos { get; set; }
        public SnakeSegment()
        {
            xPos = 0;
            yPos = 0;
        }
    }
}

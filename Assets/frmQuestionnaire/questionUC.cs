using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS_SSD_Coursework.Assets.frmQuestionAssets
{
    public partial class questionUC : UserControl
    {
        private string question;
        private string ansA;
        private string ansB;
        private string ansC;
        private string ansD;

        //constructor for user control with the question details where ansA is always the correct ans
        public questionUC(string question, string ansA, string ansB, string ansC, string ansD, Point guiPlacement, Control groupBoxParent)
        {
            //set data
            this.question = question;
            this.ansA = ansA;
            this.ansB = ansB;
            this.ansC = ansC;
            this.ansD = ansD;
            Location = guiPlacement;
            Parent = groupBoxParent;
            //gui
            InitializeComponent();
            lblQuestion.Text = string.Format("{0}?", question);

            //randomize answer placement
            string[] answers = new string[] { ansA, ansB, ansC, ansD };
            string[] shuffledAnswers = Methods.ShuffleStringArray(answers, new Random(Guid.NewGuid().GetHashCode()));
            
            radQuestionAnsA.Text = shuffledAnswers[0];
            radQuestionAnsB.Text = shuffledAnswers[1];
            radQuestionAnsC.Text = shuffledAnswers[2];
            radQuestionAnsD.Text = shuffledAnswers[3];
        }

        public int GetScore()
        {
            int score = 0;
            //check to see if selected radio button == ansA
            if (radQuestionAnsA.Checked)
            {
                //ansA is always the correct ans
                if (radQuestionAnsA.Text == ansA)
                    score = 100;
            }
            if (radQuestionAnsB.Checked)
            {
                //ansA is always the correct ans
                if (radQuestionAnsB.Text == ansA)
                    score = 100;
            }
            if (radQuestionAnsC.Checked)
            {
                //ansA is always the correct ans
                if (radQuestionAnsC.Text == ansA)
                    score = 100;
            }
            if (radQuestionAnsD.Checked)
            {
                //ansA is always the correct ans
                if (radQuestionAnsD.Text == ansA)
                    score = 100;
            }

            return score;
        }
    }
}

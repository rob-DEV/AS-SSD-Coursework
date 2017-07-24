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
using AS_SSD_Coursework.Assets.frmQuestionAssets;

namespace AS_SSD_Coursework.Levels
{
    public partial class frmQuestionnaire : Form
    {       
        //TODO: select 4 lines from the questionaire.txt
        //split by question marks
        //create instance of questionUC class
        //place in the uc in the frmQuestionaire GUI

        //create a array of questionUC or elements, these will be accessed later so need variable scope
        //inorder to calculate score
        private questionUC[] selectedQuestions;
        private int score = 0;
        public bool levelReplay = false;

        public frmQuestionnaire()
        {
            InitializeComponent();
            this.CenterToScreen();
            FormManager.Level2 = this;
            selectedQuestions = GetQuestionArray();

        }
        public frmQuestionnaire(bool Replay)
        {
            InitializeComponent();
            this.CenterToScreen();
            FormManager.Level2 = this;
            selectedQuestions = GetQuestionArray();
            levelReplay = Replay;
        }

        private questionUC[] GetQuestionArray()
        {
            //create questionUC array
            questionUC[] selectedQuestions = new questionUC[4];

            string questionText = File.ReadAllText(FilePaths.QUESTIONNAIRE);
            int numberOfQuestionsInFile = File.ReadAllLines(FilePaths.QUESTIONNAIRE).Length;
            int chosenQuestion;

            //4 random numbers for questions no duplicates
            Random randomQuestionNumber = new Random();
            HashSet<int> questionNumbers = new HashSet<int>();
            while(questionNumbers.Count < 4)
            {
                questionNumbers.Add(randomQuestionNumber.Next(1, numberOfQuestionsInFile));
            }
            //convert to array for index pointer as hashset cannot be accessed using hashset[0]
            int[] questionNumbersArray = questionNumbers.ToArray();

            //run 4 times for four questions
            for (int i = 0; i < 4; i++)
            {
                StringReader stringReader = new StringReader(questionText);
                chosenQuestion = questionNumbersArray[i];
                string questionString;
                int lineNumber = 0;
                //read question from txt file ie lineNumber = 4 means read till question 4
                while ((questionString = stringReader.ReadLine()) != null)
                {
                    lineNumber++;
                    if (lineNumber == chosenQuestion)
                        break;
                }
                //at this point the question line has been grabbed from the text file
                //it now needs to be split up into question text and answers split up by '?'
                //these will be passed into the constructor of the user control elements and positioned in the GUI form
                //the question template is
                //quest?ans1?ans2?answer3 etc
                //so these will be split up into 5 elements
                string[] questionElements = questionString.Split('?');
                //create an instance of the questionUC class

                //position the four question elements
                if (i == 0)
                    //add to array           //ucElement  //question          //ans1 (correct ans)  //ans2               //ans3              //ans4          //location in groupBox //parent
                    selectedQuestions[i] = new questionUC(questionElements[0], questionElements[1], questionElements[2], questionElements[3], questionElements[4], new Point(0, 0), grpBoxQuestionsPlaceholder);
                if (i == 1)
                    selectedQuestions[i] = new questionUC(questionElements[0], questionElements[1], questionElements[2], questionElements[3], questionElements[4], new Point(380, 0), grpBoxQuestionsPlaceholder);
                if (i == 2)
                    selectedQuestions[i] = new questionUC(questionElements[0], questionElements[1], questionElements[2], questionElements[3], questionElements[4], new Point(0, 215), grpBoxQuestionsPlaceholder);
                if (i == 3)
                    selectedQuestions[i] = new questionUC(questionElements[0], questionElements[1], questionElements[2], questionElements[3], questionElements[4], new Point(380, 215), grpBoxQuestionsPlaceholder);
            }
            return selectedQuestions;
        }

        private void btnCheckScore_Click(object sender, EventArgs e)
        {
            btnCheckScore.Enabled = false;
            foreach (questionUC question in selectedQuestions)
            {
                score += question.GetScore();
            }
            //print out score to user
            lblScore.Text = string.Format("You scored {0}!", score);
            //add score to the Player class and write to file
            Player.currentScore += score;
            Player.currentLevel = 3;
            //update file stats
            StatWriter sw = new StatWriter(FilePaths.PLAYER_STATS);
            sw.WriteStat("Score", Player.currentScore.ToString());
            sw.WriteStat("Leve2Score", score.ToString());
            sw.WriteStat("Level", Player.currentLevel.ToString());

            //wait for player to read score
            Methods.GameSleep(3000);
            
            //load level 3 
            if (!levelReplay)
            {
                frmDragGame level3 = new frmDragGame();
                level3.Show();
                this.Hide();
                level3.FormClosing += (s, args) => this.Close();
            }
            else
            {
                //else just exit out of level
                this.Close();
            }
        }
    }
}

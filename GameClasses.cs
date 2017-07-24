using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Threading;
using AS_SSD_Coursework.Menus;
using AS_SSD_Coursework.Levels;


namespace AS_SSD_Coursework
{
    public static class Player
    {
        //this static class hold scores / data whilst moving between levels
        //global variables
        public static string playerName = string.Empty;
        public static int currentLevel = 0;
        public static int currentScore = 0;
        /// <summary>
        /// Inserts playerName and level to stat file
        /// </summary>
        public static void SetupPlayerInitally(string playerName, Image playerAvatar)
        {
            //setup global variables
            Player.playerName = playerName;
            Player.currentScore = 0;
            //new instance of StatWriter class
            StatWriter statWriter = new StatWriter(FilePaths.PLAYER_STATS);
            //removes the ---EMPTY--- placeholder text
            statWriter.ClearStats();
            //insert stats
            statWriter.WriteStat("Player", playerName);
            statWriter.WriteStat("Level", "1");
            statWriter.WriteStat("Score", "0");
            //save avatar or personal picture to binary file
            ImageConverter converter = new ImageConverter();
            byte[] imageInBytes = (byte[])converter.ConvertTo(playerAvatar, typeof(byte[]));
            File.WriteAllBytes(FilePaths.AVATAR_BIN, imageInBytes);
        }
        public static Image GetAvatarFromBinFile()
        {
            byte[] imageBytes = File.ReadAllBytes(FilePaths.AVATAR_BIN);

            using(MemoryStream ms = new MemoryStream(imageBytes))
            {
                Bitmap img = (Bitmap)Image.FromStream(ms);
                return img;
            }
        }
    }
    public static class FilePaths
    {
        //provides the location of the players data
        public const string PLAYER_STATS = @"../../Assets/Files/PlayerDetails.txt";
        //about box text file
        public const string ABOUT_TEXT = @"../../Assets/Files/About.txt";
        //highscores text file
        public const string HIGHSCORES = @"../../Assets/Files/HighScores.txt";
        //avatar.dat location
        public const string AVATAR_BIN = @"../../Assets/Files/PlayerAvatar.dat";
        //Questionaire.txt location holds questions for frmQuestionaire
        public const string QUESTIONNAIRE = @"../../Assets/Files/Questionnaire.txt";


        //create stat file and bin file for the first time
        public static void CreatePlayerFiles()
        {
            try
            {
                if (!File.Exists(PLAYER_STATS))
                    File.Create(PLAYER_STATS);
                if (!File.Exists(AVATAR_BIN))
                    File.Create(AVATAR_BIN);
                if (!File.Exists(HIGHSCORES))
                    File.Create(HIGHSCORES);
            }
            catch (Exception e)
            {

                Console.WriteLine("Error: {0}", e.Message);
            }
        }
    }
    public static class FormManager
    {
        //hold all the form instances, allowing me to easily show or hide any form from anywhere
        //for example when returning to the main menu
        //levels
        public static frmMainMenu MainMenu { get; set; }
        public static frmLogoQuiz Level1 { get; set; }
        public static frmQuestionnaire Level2 { get; set; }
        public static frmDragGame Level3 { get; set; }
        public static frmSnakeGame Level4 { get; set; }
    }
    public static class Methods
    {
        public static string[] ShuffleStringArray(string[] array, Random r)
        {
            
            for (int i = array.Length; i > 0; i--)
            {
                int j = r.Next(i);
                string k = array[j];
                array[j] = array[i - 1];
                array[i - 1] = k;
            }
            return array;
        }
        public static void GameSleep(int millisecondsToWait)
        {
            System.Windows.Forms.Application.DoEvents();
            Thread.Sleep(3000);
        }
    }

    public class StatReader
    {
        private string path;
        //constructor
        public StatReader(string path) 
        {
            this.path = path;
        }
        public bool CheckForEmptyFile()
        {
            if (this.ReadStat(1) == null)
                return true;
            else
                return false;
        }
        /// <summary>
        /// Read a stat form file line
        /// </summary>
        /// <param name="_lineNumber"></param>
        /// <returns></returns>
        public string ReadStat(int _lineNumber)
        {
            string result = "";
            try
            {
                StreamReader sr = new StreamReader(path);
                for (int i = 0; i < _lineNumber; i++)
                {
                    result = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception e)
            {

                return e.Message;
            }
            return result;
        }
        /// <summary>
        /// Overload to read a stat by name
        /// </summary>
        /// <param name="_statName"></param>
        /// <returns></returns>
        public string ReadStat(string _statName)
        {
            string statValue = "";
            try
            {
                StreamReader sr = new StreamReader(path);
                //read each line until the one with the _statName appears and get statValue
                string currentLine;
                while((currentLine = sr.ReadLine()) != null)
                {
                    //grab the stat value and pass back
                    if (currentLine.Contains(_statName))
                    {
                        statValue = currentLine.Split('>')[1];
                        sr.Close();
                        return statValue;
                    }
                }
                //stat not found
                return "Stat not found";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
    public class StatWriter
    {
        string path;
        //construtor
        public StatWriter(string path)
        {
            this.path = path;
        }
        //Wipes the stat file
        public void ClearStats()
        {
            try
            {
                StreamWriter sw = new StreamWriter(path);
                sw.Write("");
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }

        }
        /// <summary>
        /// Write a stat to the file
        /// </summary>
        /// <param name="_statName"></param>
        /// <param name="_statValue"></param>
        public void WriteStat(string _statName, string _statValue)
        {
            //stat template  statName>statValue
            string contents = File.ReadAllText(path);
            //setup stat to find it (see stat template)
            string statTemplate = _statName + ">";
            //stat already exist just needs updated
            if (contents.Contains(_statName))
            {
                //get old stat line to replace
                try
                {
                    StringReader stringReader = new StringReader(contents);

                    string currentLine;
                    while ((currentLine = stringReader.ReadLine()) != null)
                    {
                        if (currentLine.Contains(_statName))
                            break;
                    }
                    //replace old stat wih new one and write back
                    File.WriteAllText(path, contents.Replace(currentLine, statTemplate + _statValue));
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: {0}", e.Message);
                }
            }
            else
            {
                try
                {
                    //just insert stat as new
                    StreamWriter sw = new StreamWriter(path, true);
                    sw.WriteLine(statTemplate + _statValue);
                    sw.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: {0}", e.Message);
                }
            }

        }
    }
}

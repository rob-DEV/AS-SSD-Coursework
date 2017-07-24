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
using AS_SSD_Coursework.Assets.frmSnakeAssets;

namespace AS_SSD_Coursework.Levels
{
    public partial class frmSnakeGame : Form
    {
        /// <summary>
        /// All files for the snake game are located in Assets/frmSnakeAssets
        /// </summary>
        //holds all the snake segments to render to the canvas, see SnakeSegmentClass
        private List<SnakeSegment> snake = new List<SnakeSegment>();

        public Thread gameThread;
        private SnakeGameManager SGM = new SnakeGameManager();
        private SnakeSegment foodPiece;
        private int direction; // Down = 0, Left = 1, Right = 2, Up = 3
        private int score;
        public bool levelReplay = false;

        public frmSnakeGame()
        {
            InitializeComponent();
            this.CenterToScreen();
            FormManager.Level4 = this;
            MessageBox.Show("YOU HAVE UNLOCKED THE SECRET LEVEL!");
            StartGame();
        }
        public frmSnakeGame(bool replay)
        {
            InitializeComponent();
            this.levelReplay = replay;
            this.CenterToScreen();
            FormManager.Level4 = this;
            StartGame();

        }
        private void StartGame()
        {
            lblHeaderText.Text = "Use W, A, S, D to controls the Snake, press PAUSE or SPACE to pause the game!";
            //start game on a new thread to allow simple GUI updating
            gameThread = new Thread(new ThreadStart(GameInit));
            gameThread.Start();
            //handle thread close
            this.FormClosing += delegate { gameThread.Abort(); };

            //initalize and set gamestate to running
            //this enum controls the game loop below
            SGM.gameState = GameState.Running;
            //set score to 0
            score = 0;
            direction = 0;
            snake.Clear();
            //create the snakes head, give it a position and add it to the list of snake segments
            SnakeSegment head = new SnakeSegment();
            head.xPos = 10;
            head.yPos = 5;
            snake.Add(head);
            //create to first bit of snake food
            GenerateFood();
        }
        private void GameInit()
        {
            while (true)
            {
                while (SGM.gameState == GameState.Running)
                {
                    //updates the second every x milliseconds ie 1000 / 100 == 10 Frames per second
                    //this determines the speed of the snake
                    Thread.Sleep(50);
                    //delegate allows communication between code in the form and code executing in the thread
                    this.Invoke((MethodInvoker)delegate
                    {
                        UpdateSnake();
                    //clears the canvas to redraw the snake every frame
                    pbGameCanvas.Invalidate();
                    });
                } 
            }
        }
        private void GenerateFood()
        {
            int maxWidth = pbGameCanvas.Size.Width / 16;
            int maxHeight = pbGameCanvas.Size.Height / 16;
            Random random = new Random();
            foodPiece = new SnakeSegment();
            foodPiece.xPos = random.Next(0, maxWidth);
            foodPiece.yPos = random.Next(0, maxHeight);
        }
        private void UpdateSnake()
        {
            for (int i = snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (direction)
                    {
                        case 0: // Down
                            snake[i].yPos++;
                            break;
                        case 1: // Left
                            snake[i].xPos--;
                            break;
                        case 2: // Right
                            snake[i].xPos++;
                            break;
                        case 3: // Up
                            snake[i].yPos--;
                            break;
                    }
                    int max_tile_w = pbGameCanvas.Width / 16;
                    int max_tile_h = pbGameCanvas.Height / 16;
                    //if snake leaves game area stop the game loop
                    if (snake[i].xPos < 0 || snake[i].xPos >= max_tile_w || snake[i].yPos < 0 || snake[i].yPos >= max_tile_h)
                    {
                        //changing the gamestate stops the threaded loop
                        SGM.gameState = GameState.Stopped;
                        EndGame();
                    }
                    for (int j = 1; j < snake.Count; j++)
                        //if the snake collides with itself end the game
                        if (snake[i].xPos == snake[j].xPos && snake[i].yPos == snake[j].yPos)
                        {
                            //changing the gamestate stops the threaded loop
                            SGM.gameState = GameState.Stopped;
                            EndGame();
                        }
                    //when the head of the snake collides with the food add 100 to the score and spawn in a new
                    //piece of food
                    if (snake[i].xPos == foodPiece.xPos && snake[i].yPos == foodPiece.yPos)
                    {
                        SnakeSegment part = new SnakeSegment();
                        part.xPos = snake[snake.Count - 1].xPos;
                        part.yPos = snake[snake.Count - 1].yPos;
                        snake.Add(part);
                        GenerateFood();
                        score += 100;
                    }
                }
                else
                {
                    snake[i].xPos = snake[i - 1].xPos;
                    snake[i].yPos = snake[i - 1].yPos;
                }
            }
        }
        private void EndGame()
        {
            //I wont count score as this isn't the quiz this is the secret level for completing the quiz
            //goto Level2 only if the level isn't being replayed
            if (levelReplay == false)
            {
                //load the decision form
                frmSnakeEnd endGame = new frmSnakeEnd();
                endGame.ShowDialog();
                
            }
            else
            {
                this.Close();
            }
        }
        public void ResetGame()
        {
            //this run if the user wishes to redo the snake level at the end
            //it closes the thread, ready to restart all processes
            this.snake = new List<SnakeSegment>();
            this.gameThread.Abort();
            this.gameThread = null;
            this.direction = 0;
            this.foodPiece = null;
            this.score = 0;
            this.StartGame();
        }
        private void pbGameCanvas_Paint(object sender, PaintEventArgs e)
        {
            //redraws the scene every frame
            Graphics canvas = e.Graphics;
            for (int i = 0; i < snake.Count; i++)
            {
                //take the snake segment position and translate in to the screen snake[i].xPos
                Brush snake_color = i == 0 ? Brushes.Red : Brushes.White;
                canvas.FillRectangle(snake_color, new Rectangle(snake[i].xPos * 16, snake[i].yPos * 16, 16, 16));
            }
            canvas.FillRectangle(Brushes.Gold, new Rectangle(foodPiece.xPos * 16, foodPiece.yPos * 16, 16, 16));
            canvas.DrawString("Score: " + score.ToString(), this.Font, Brushes.Blue, new PointF(4, 4));
        }
        private void frmSnakeGame_KeyDown(object sender, KeyEventArgs e)
        {
            //update direction based on user keypress
            // Down = 0, Left = 1, Right = 2, Up = 3
            if (e.KeyCode == Keys.W)
                //stops the snake back tracking on itself
                if (snake.Count < 2 || snake[0].yPos == snake[1].yPos)
                    direction = 3;
            if (e.KeyCode == Keys.A)
                //stops the snake back tracking on itself
                if (snake.Count < 2 || snake[0].xPos == snake[1].xPos)
                    direction = 1;
            if (e.KeyCode == Keys.S)
                //stops the snake back tracking on itself
                if (snake.Count < 2 || snake[0].yPos == snake[1].yPos)
                    direction = 0;
            if (e.KeyCode == Keys.D)
                //stops the snake back tracking on itself
                if (snake.Count < 2 || snake[0].xPos == snake[1].xPos)
                    direction = 2;
        }
        private void btnPauseGame_Click(object sender, EventArgs e)
        {
            if(SGM.gameState == GameState.Running)
            {
                SGM.gameState = GameState.Stopped;
            }else
            {
                SGM.gameState = GameState.Running;
            }
        }
    }
}

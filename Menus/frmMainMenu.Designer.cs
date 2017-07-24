namespace AS_SSD_Coursework.Menus
{
    partial class frmMainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.btnPlayGame = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblMOTD = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.panPlayerStats = new System.Windows.Forms.Panel();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.btnReplay = new System.Windows.Forms.Button();
            this.btnHighScores = new System.Windows.Forms.Button();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leaderboardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTheGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.panPlayerStats.SuspendLayout();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlayGame
            // 
            this.btnPlayGame.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPlayGame.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayGame.ForeColor = System.Drawing.Color.White;
            this.btnPlayGame.Location = new System.Drawing.Point(114, 206);
            this.btnPlayGame.Name = "btnPlayGame";
            this.btnPlayGame.Size = new System.Drawing.Size(81, 54);
            this.btnPlayGame.TabIndex = 1;
            this.btnPlayGame.Text = "PLAY";
            this.btnPlayGame.UseVisualStyleBackColor = false;
            this.btnPlayGame.Click += new System.EventHandler(this.btnPlayGame_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnQuit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.White;
            this.btnQuit.Location = new System.Drawing.Point(225, 206);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(81, 54);
            this.btnQuit.TabIndex = 1;
            this.btnQuit.Text = "QUIT";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblMOTD
            // 
            this.lblMOTD.AutoSize = true;
            this.lblMOTD.BackColor = System.Drawing.Color.Transparent;
            this.lblMOTD.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMOTD.ForeColor = System.Drawing.Color.White;
            this.lblMOTD.Location = new System.Drawing.Point(65, 177);
            this.lblMOTD.Name = "lblMOTD";
            this.lblMOTD.Size = new System.Drawing.Size(405, 21);
            this.lblMOTD.TabIndex = 2;
            this.lblMOTD.Text = "Continue from where you left off or Start a New Game";
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNewGame.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.ForeColor = System.Drawing.Color.White;
            this.btnNewGame.Location = new System.Drawing.Point(175, 307);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(184, 31);
            this.btnNewGame.TabIndex = 4;
            this.btnNewGame.Text = "START A NEW GAME";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // picAvatar
            // 
            this.picAvatar.BackColor = System.Drawing.Color.Transparent;
            this.picAvatar.Location = new System.Drawing.Point(1, 1);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(70, 70);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 5;
            this.picAvatar.TabStop = false;
            // 
            // panPlayerStats
            // 
            this.panPlayerStats.BackColor = System.Drawing.Color.Transparent;
            this.panPlayerStats.Controls.Add(this.lblPlayerScore);
            this.panPlayerStats.Controls.Add(this.lblPlayerName);
            this.panPlayerStats.Controls.Add(this.picAvatar);
            this.panPlayerStats.Location = new System.Drawing.Point(109, 97);
            this.panPlayerStats.Name = "panPlayerStats";
            this.panPlayerStats.Size = new System.Drawing.Size(317, 72);
            this.panPlayerStats.TabIndex = 6;
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerScore.ForeColor = System.Drawing.Color.White;
            this.lblPlayerScore.Location = new System.Drawing.Point(74, 39);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(51, 20);
            this.lblPlayerScore.TabIndex = 6;
            this.lblPlayerScore.Text = "Score:";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.ForeColor = System.Drawing.Color.White;
            this.lblPlayerName.Location = new System.Drawing.Point(74, 13);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(240, 20);
            this.lblPlayerName.TabIndex = 6;
            this.lblPlayerName.Text = "Welcome back, ";
            // 
            // btnReplay
            // 
            this.btnReplay.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnReplay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplay.ForeColor = System.Drawing.Color.White;
            this.btnReplay.Location = new System.Drawing.Point(175, 268);
            this.btnReplay.Name = "btnReplay";
            this.btnReplay.Size = new System.Drawing.Size(184, 31);
            this.btnReplay.TabIndex = 4;
            this.btnReplay.Text = "REPLAY LEVEL";
            this.btnReplay.UseVisualStyleBackColor = false;
            this.btnReplay.Click += new System.EventHandler(this.btnSelectLevel_Click);
            // 
            // btnHighScores
            // 
            this.btnHighScores.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnHighScores.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHighScores.ForeColor = System.Drawing.Color.White;
            this.btnHighScores.Location = new System.Drawing.Point(340, 206);
            this.btnHighScores.Name = "btnHighScores";
            this.btnHighScores.Size = new System.Drawing.Size(81, 54);
            this.btnHighScores.TabIndex = 1;
            this.btnHighScores.Text = "HIGH SCORES";
            this.btnHighScores.UseVisualStyleBackColor = false;
            this.btnHighScores.Click += new System.EventHandler(this.btnHighScores_Click);
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.leaderboardsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(534, 24);
            this.menuMain.TabIndex = 7;
            this.menuMain.Text = "menuStripMainMenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "Exit";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // leaderboardsToolStripMenuItem
            // 
            this.leaderboardsToolStripMenuItem.Name = "leaderboardsToolStripMenuItem";
            this.leaderboardsToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.leaderboardsToolStripMenuItem.Text = "Leaderboards";
            this.leaderboardsToolStripMenuItem.Click += new System.EventHandler(this.leaderboardsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutTheGameToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutTheGameToolStripMenuItem
            // 
            this.aboutTheGameToolStripMenuItem.Name = "aboutTheGameToolStripMenuItem";
            this.aboutTheGameToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.aboutTheGameToolStripMenuItem.Text = "About The Game";
            this.aboutTheGameToolStripMenuItem.Click += new System.EventHandler(this.aboutTheGameToolStripMenuItem_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(168, 41);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(199, 45);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "The Big Quiz";
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panPlayerStats);
            this.Controls.Add(this.btnReplay);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblMOTD);
            this.Controls.Add(this.btnHighScores);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnPlayGame);
            this.Controls.Add(this.menuMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuMain;
            this.MaximizeBox = false;
            this.Name = "frmMainMenu";
            this.Text = "Welcome to The Impossiblish Game";
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.panPlayerStats.ResumeLayout(false);
            this.panPlayerStats.PerformLayout();
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlayGame;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblMOTD;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Panel panPlayerStats;
        private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Button btnReplay;
        private System.Windows.Forms.Button btnHighScores;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutTheGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leaderboardsToolStripMenuItem;
        private System.Windows.Forms.Label lblTitle;
    }
}


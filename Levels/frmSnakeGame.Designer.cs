namespace AS_SSD_Coursework.Levels
{
    partial class frmSnakeGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSnakeGame));
            this.btnPauseGame = new System.Windows.Forms.Button();
            this.pbGameCanvas = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblHeaderText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbGameCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPauseGame
            // 
            this.btnPauseGame.Location = new System.Drawing.Point(13, 7);
            this.btnPauseGame.Name = "btnPauseGame";
            this.btnPauseGame.Size = new System.Drawing.Size(93, 23);
            this.btnPauseGame.TabIndex = 1;
            this.btnPauseGame.Text = "Pause";
            this.btnPauseGame.UseVisualStyleBackColor = true;
            this.btnPauseGame.Click += new System.EventHandler(this.btnPauseGame_Click);
            // 
            // pbGameCanvas
            // 
            this.pbGameCanvas.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pbGameCanvas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbGameCanvas.Location = new System.Drawing.Point(6, 40);
            this.pbGameCanvas.Name = "pbGameCanvas";
            this.pbGameCanvas.Size = new System.Drawing.Size(640, 480);
            this.pbGameCanvas.TabIndex = 2;
            this.pbGameCanvas.TabStop = false;
            this.pbGameCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pbGameCanvas_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(0, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(653, 493);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pbGameCanvas_Paint);
            // 
            // lblHeaderText
            // 
            this.lblHeaderText.AutoSize = true;
            this.lblHeaderText.BackColor = System.Drawing.Color.Transparent;
            this.lblHeaderText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderText.ForeColor = System.Drawing.Color.White;
            this.lblHeaderText.Location = new System.Drawing.Point(119, 11);
            this.lblHeaderText.Name = "lblHeaderText";
            this.lblHeaderText.Size = new System.Drawing.Size(285, 17);
            this.lblHeaderText.TabIndex = 3;
            this.lblHeaderText.Text = "You have unlocked a SECRET level well done!";
            // 
            // frmSnakeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(654, 526);
            this.Controls.Add(this.lblHeaderText);
            this.Controls.Add(this.pbGameCanvas);
            this.Controls.Add(this.btnPauseGame);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmSnakeGame";
            this.Text = "Final Level - Snake Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSnakeGame_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbGameCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPauseGame;
        private System.Windows.Forms.PictureBox pbGameCanvas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHeaderText;
    }
}
namespace AS_SSD_Coursework.Levels
{
    partial class frmLogoQuiz
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogoQuiz));
            this.pbBT = new System.Windows.Forms.PictureBox();
            this.pbSkype = new System.Windows.Forms.PictureBox();
            this.pbLego = new System.Windows.Forms.PictureBox();
            this.pbVW = new System.Windows.Forms.PictureBox();
            this.lblTimeTaken = new System.Windows.Forms.Label();
            this.txtBT = new System.Windows.Forms.TextBox();
            this.lblHeaderText = new System.Windows.Forms.Label();
            this.txtLego = new System.Windows.Forms.TextBox();
            this.txtSkype = new System.Windows.Forms.TextBox();
            this.txtVW = new System.Windows.Forms.TextBox();
            this.txtSubmitScore = new System.Windows.Forms.Button();
            this.timerLevel1 = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSkype)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLego)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVW)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBT
            // 
            this.pbBT.Image = ((System.Drawing.Image)(resources.GetObject("pbBT.Image")));
            this.pbBT.Location = new System.Drawing.Point(56, 77);
            this.pbBT.Name = "pbBT";
            this.pbBT.Size = new System.Drawing.Size(120, 120);
            this.pbBT.TabIndex = 0;
            this.pbBT.TabStop = false;
            // 
            // pbSkype
            // 
            this.pbSkype.Image = ((System.Drawing.Image)(resources.GetObject("pbSkype.Image")));
            this.pbSkype.Location = new System.Drawing.Point(56, 260);
            this.pbSkype.Name = "pbSkype";
            this.pbSkype.Size = new System.Drawing.Size(120, 120);
            this.pbSkype.TabIndex = 1;
            this.pbSkype.TabStop = false;
            // 
            // pbLego
            // 
            this.pbLego.Image = ((System.Drawing.Image)(resources.GetObject("pbLego.Image")));
            this.pbLego.Location = new System.Drawing.Point(279, 77);
            this.pbLego.Name = "pbLego";
            this.pbLego.Size = new System.Drawing.Size(120, 120);
            this.pbLego.TabIndex = 2;
            this.pbLego.TabStop = false;
            // 
            // pbVW
            // 
            this.pbVW.Image = ((System.Drawing.Image)(resources.GetObject("pbVW.Image")));
            this.pbVW.Location = new System.Drawing.Point(279, 260);
            this.pbVW.Name = "pbVW";
            this.pbVW.Size = new System.Drawing.Size(120, 120);
            this.pbVW.TabIndex = 3;
            this.pbVW.TabStop = false;
            // 
            // lblTimeTaken
            // 
            this.lblTimeTaken.AutoSize = true;
            this.lblTimeTaken.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeTaken.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeTaken.ForeColor = System.Drawing.Color.White;
            this.lblTimeTaken.Location = new System.Drawing.Point(204, 51);
            this.lblTimeTaken.Name = "lblTimeTaken";
            this.lblTimeTaken.Size = new System.Drawing.Size(46, 25);
            this.lblTimeTaken.TabIndex = 4;
            this.lblTimeTaken.Text = "0:00";
            this.lblTimeTaken.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBT
            // 
            this.txtBT.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBT.Location = new System.Drawing.Point(56, 202);
            this.txtBT.MaxLength = 20;
            this.txtBT.Name = "txtBT";
            this.txtBT.Size = new System.Drawing.Size(120, 25);
            this.txtBT.TabIndex = 1;
            // 
            // lblHeaderText
            // 
            this.lblHeaderText.AutoSize = true;
            this.lblHeaderText.BackColor = System.Drawing.Color.Transparent;
            this.lblHeaderText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderText.ForeColor = System.Drawing.Color.White;
            this.lblHeaderText.Location = new System.Drawing.Point(10, 23);
            this.lblHeaderText.Name = "lblHeaderText";
            this.lblHeaderText.Size = new System.Drawing.Size(435, 21);
            this.lblHeaderText.TabIndex = 8;
            this.lblHeaderText.Text = "Guess the logos the quicker you are the more you score!";
            this.lblHeaderText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLego
            // 
            this.txtLego.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLego.Location = new System.Drawing.Point(278, 202);
            this.txtLego.MaxLength = 20;
            this.txtLego.Name = "txtLego";
            this.txtLego.Size = new System.Drawing.Size(121, 25);
            this.txtLego.TabIndex = 2;
            // 
            // txtSkype
            // 
            this.txtSkype.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSkype.Location = new System.Drawing.Point(56, 389);
            this.txtSkype.MaxLength = 20;
            this.txtSkype.Name = "txtSkype";
            this.txtSkype.Size = new System.Drawing.Size(120, 25);
            this.txtSkype.TabIndex = 3;
            // 
            // txtVW
            // 
            this.txtVW.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVW.Location = new System.Drawing.Point(278, 389);
            this.txtVW.MaxLength = 20;
            this.txtVW.Name = "txtVW";
            this.txtVW.Size = new System.Drawing.Size(121, 25);
            this.txtVW.TabIndex = 4;
            // 
            // txtSubmitScore
            // 
            this.txtSubmitScore.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubmitScore.Location = new System.Drawing.Point(184, 464);
            this.txtSubmitScore.Name = "txtSubmitScore";
            this.txtSubmitScore.Size = new System.Drawing.Size(86, 31);
            this.txtSubmitScore.TabIndex = 5;
            this.txtSubmitScore.Text = "Done";
            this.txtSubmitScore.UseVisualStyleBackColor = true;
            this.txtSubmitScore.Click += new System.EventHandler(this.txtSubmitScore_Click);
            // 
            // timerLevel1
            // 
            this.timerLevel1.Interval = 1000;
            this.timerLevel1.Tick += new System.EventHandler(this.timerLevel1_Tick);
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Blue;
            this.lblScore.Location = new System.Drawing.Point(56, 429);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(343, 23);
            this.lblScore.TabIndex = 9;
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmLogoQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(454, 506);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.txtSubmitScore);
            this.Controls.Add(this.lblHeaderText);
            this.Controls.Add(this.txtVW);
            this.Controls.Add(this.txtSkype);
            this.Controls.Add(this.txtLego);
            this.Controls.Add(this.txtBT);
            this.Controls.Add(this.lblTimeTaken);
            this.Controls.Add(this.pbVW);
            this.Controls.Add(this.pbLego);
            this.Controls.Add(this.pbSkype);
            this.Controls.Add(this.pbBT);
            this.Name = "frmLogoQuiz";
            this.Text = "Level 1 - LogoQuiz";
            ((System.ComponentModel.ISupportInitialize)(this.pbBT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSkype)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLego)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBT;
        private System.Windows.Forms.PictureBox pbSkype;
        private System.Windows.Forms.PictureBox pbLego;
        private System.Windows.Forms.PictureBox pbVW;
        private System.Windows.Forms.Label lblTimeTaken;
        private System.Windows.Forms.TextBox txtBT;
        private System.Windows.Forms.Label lblHeaderText;
        private System.Windows.Forms.TextBox txtLego;
        private System.Windows.Forms.TextBox txtSkype;
        private System.Windows.Forms.TextBox txtVW;
        private System.Windows.Forms.Button txtSubmitScore;
        private System.Windows.Forms.Timer timerLevel1;
        private System.Windows.Forms.Label lblScore;
    }
}
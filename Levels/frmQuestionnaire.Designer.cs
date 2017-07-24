namespace AS_SSD_Coursework.Levels
{
    partial class frmQuestionnaire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuestionnaire));
            this.grpBoxQuestionsPlaceholder = new System.Windows.Forms.GroupBox();
            this.btnCheckScore = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblHeaderText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // grpBoxQuestionsPlaceholder
            // 
            this.grpBoxQuestionsPlaceholder.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxQuestionsPlaceholder.Location = new System.Drawing.Point(12, 41);
            this.grpBoxQuestionsPlaceholder.Name = "grpBoxQuestionsPlaceholder";
            this.grpBoxQuestionsPlaceholder.Size = new System.Drawing.Size(760, 430);
            this.grpBoxQuestionsPlaceholder.TabIndex = 0;
            this.grpBoxQuestionsPlaceholder.TabStop = false;
            // 
            // btnCheckScore
            // 
            this.btnCheckScore.Location = new System.Drawing.Point(355, 481);
            this.btnCheckScore.Name = "btnCheckScore";
            this.btnCheckScore.Size = new System.Drawing.Size(75, 23);
            this.btnCheckScore.TabIndex = 1;
            this.btnCheckScore.Text = "Done";
            this.btnCheckScore.UseVisualStyleBackColor = true;
            this.btnCheckScore.Click += new System.EventHandler(this.btnCheckScore_Click);
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(355, 15);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(418, 23);
            this.lblScore.TabIndex = 10;
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeaderText
            // 
            this.lblHeaderText.AutoSize = true;
            this.lblHeaderText.BackColor = System.Drawing.Color.Transparent;
            this.lblHeaderText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderText.ForeColor = System.Drawing.Color.White;
            this.lblHeaderText.Location = new System.Drawing.Point(13, 17);
            this.lblHeaderText.Name = "lblHeaderText";
            this.lblHeaderText.Size = new System.Drawing.Size(408, 17);
            this.lblHeaderText.TabIndex = 11;
            this.lblHeaderText.Text = "Answer each question on history, the questions are given at random.";
            // 
            // frmQuestionnaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.lblHeaderText);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnCheckScore);
            this.Controls.Add(this.grpBoxQuestionsPlaceholder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmQuestionnaire";
            this.Text = "Level 2 - Questionnaire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxQuestionsPlaceholder;
        private System.Windows.Forms.Button btnCheckScore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblHeaderText;
    }
}
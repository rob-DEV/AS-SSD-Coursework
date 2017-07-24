namespace AS_SSD_Coursework.Menus
{
    partial class frmPlayerSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlayerSetup));
            this.lblName = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblChooseAvatar = new System.Windows.Forms.Label();
            this.picAvatarA = new System.Windows.Forms.PictureBox();
            this.picAvatarB = new System.Windows.Forms.PictureBox();
            this.picAvatarC = new System.Windows.Forms.PictureBox();
            this.btnBrowseForAvatar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatarA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatarB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatarC)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(20, 55);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 21);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(41, 19);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(200, 25);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Enter Your Username";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(83, 56);
            this.txtName.MaxLength = 20;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(182, 20);
            this.txtName.TabIndex = 2;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(101, 234);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(83, 40);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Done";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblChooseAvatar
            // 
            this.lblChooseAvatar.AutoSize = true;
            this.lblChooseAvatar.BackColor = System.Drawing.Color.Transparent;
            this.lblChooseAvatar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseAvatar.ForeColor = System.Drawing.Color.White;
            this.lblChooseAvatar.Location = new System.Drawing.Point(20, 91);
            this.lblChooseAvatar.Name = "lblChooseAvatar";
            this.lblChooseAvatar.Size = new System.Drawing.Size(141, 21);
            this.lblChooseAvatar.TabIndex = 4;
            this.lblChooseAvatar.Text = "Choose an avatar";
            // 
            // picAvatarA
            // 
            this.picAvatarA.Image = ((System.Drawing.Image)(resources.GetObject("picAvatarA.Image")));
            this.picAvatarA.ImageLocation = "";
            this.picAvatarA.Location = new System.Drawing.Point(21, 120);
            this.picAvatarA.Name = "picAvatarA";
            this.picAvatarA.Size = new System.Drawing.Size(70, 70);
            this.picAvatarA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatarA.TabIndex = 5;
            this.picAvatarA.TabStop = false;
            this.picAvatarA.Click += new System.EventHandler(this.picAvatar_Click);
            // 
            // picAvatarB
            // 
            this.picAvatarB.BackColor = System.Drawing.Color.Transparent;
            this.picAvatarB.Image = ((System.Drawing.Image)(resources.GetObject("picAvatarB.Image")));
            this.picAvatarB.Location = new System.Drawing.Point(107, 120);
            this.picAvatarB.Name = "picAvatarB";
            this.picAvatarB.Size = new System.Drawing.Size(70, 70);
            this.picAvatarB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatarB.TabIndex = 6;
            this.picAvatarB.TabStop = false;
            this.picAvatarB.Click += new System.EventHandler(this.picAvatar_Click);
            // 
            // picAvatarC
            // 
            this.picAvatarC.BackColor = System.Drawing.Color.Transparent;
            this.picAvatarC.Image = ((System.Drawing.Image)(resources.GetObject("picAvatarC.Image")));
            this.picAvatarC.Location = new System.Drawing.Point(193, 120);
            this.picAvatarC.Name = "picAvatarC";
            this.picAvatarC.Size = new System.Drawing.Size(70, 70);
            this.picAvatarC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatarC.TabIndex = 7;
            this.picAvatarC.TabStop = false;
            this.picAvatarC.Click += new System.EventHandler(this.picAvatar_Click);
            // 
            // btnBrowseForAvatar
            // 
            this.btnBrowseForAvatar.Location = new System.Drawing.Point(105, 200);
            this.btnBrowseForAvatar.Name = "btnBrowseForAvatar";
            this.btnBrowseForAvatar.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseForAvatar.TabIndex = 8;
            this.btnBrowseForAvatar.Text = "Browse...";
            this.btnBrowseForAvatar.UseVisualStyleBackColor = true;
            this.btnBrowseForAvatar.Click += new System.EventHandler(this.btnBrowseForAvatar_Click);
            // 
            // frmPlayerSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 291);
            this.Controls.Add(this.btnBrowseForAvatar);
            this.Controls.Add(this.picAvatarC);
            this.Controls.Add(this.picAvatarB);
            this.Controls.Add(this.picAvatarA);
            this.Controls.Add(this.lblChooseAvatar);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPlayerSetup";
            this.Text = "New Game";
            ((System.ComponentModel.ISupportInitialize)(this.picAvatarA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatarB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatarC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblChooseAvatar;
        private System.Windows.Forms.PictureBox picAvatarA;
        private System.Windows.Forms.PictureBox picAvatarB;
        private System.Windows.Forms.PictureBox picAvatarC;
        private System.Windows.Forms.Button btnBrowseForAvatar;
    }
}
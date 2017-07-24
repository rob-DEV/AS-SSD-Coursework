namespace AS_SSD_Coursework.Levels
{
    partial class frmDragGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDragGame));
            this.lblHeaderText = new System.Windows.Forms.Label();
            this.lblMecury = new System.Windows.Forms.Label();
            this.picPlanet1 = new System.Windows.Forms.PictureBox();
            this.picPlanet2 = new System.Windows.Forms.PictureBox();
            this.lblVenus = new System.Windows.Forms.Label();
            this.picPlanet3 = new System.Windows.Forms.PictureBox();
            this.lblEarth = new System.Windows.Forms.Label();
            this.picPlanet4 = new System.Windows.Forms.PictureBox();
            this.picPlanet5 = new System.Windows.Forms.PictureBox();
            this.picPlanet6 = new System.Windows.Forms.PictureBox();
            this.lblMars = new System.Windows.Forms.Label();
            this.lblJupiter = new System.Windows.Forms.Label();
            this.lblSaturn = new System.Windows.Forms.Label();
            this.picPlanet7 = new System.Windows.Forms.PictureBox();
            this.picPlanet8 = new System.Windows.Forms.PictureBox();
            this.lblUranus = new System.Windows.Forms.Label();
            this.lblNeptune = new System.Windows.Forms.Label();
            this.picEarth = new System.Windows.Forms.PictureBox();
            this.picNeptune = new System.Windows.Forms.PictureBox();
            this.picMars = new System.Windows.Forms.PictureBox();
            this.picSaturn = new System.Windows.Forms.PictureBox();
            this.picUranus = new System.Windows.Forms.PictureBox();
            this.picMercury = new System.Windows.Forms.PictureBox();
            this.picVenus = new System.Windows.Forms.PictureBox();
            this.picJupiter = new System.Windows.Forms.PictureBox();
            this.btnCheckScore = new System.Windows.Forms.Button();
            this.lblTimeTaken = new System.Windows.Forms.Label();
            this.timerLevel3 = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPlanet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlanet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlanet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlanet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlanet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlanet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlanet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlanet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEarth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNeptune)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSaturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUranus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMercury)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVenus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJupiter)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeaderText
            // 
            this.lblHeaderText.AutoSize = true;
            this.lblHeaderText.BackColor = System.Drawing.Color.Transparent;
            this.lblHeaderText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderText.ForeColor = System.Drawing.Color.White;
            this.lblHeaderText.Location = new System.Drawing.Point(12, 13);
            this.lblHeaderText.Name = "lblHeaderText";
            this.lblHeaderText.Size = new System.Drawing.Size(467, 30);
            this.lblHeaderText.TabIndex = 12;
            this.lblHeaderText.Text = "Drag and drop the planet, be quick for a bonus!! ";
            // 
            // lblMecury
            // 
            this.lblMecury.AutoSize = true;
            this.lblMecury.BackColor = System.Drawing.Color.Transparent;
            this.lblMecury.ForeColor = System.Drawing.Color.White;
            this.lblMecury.Location = new System.Drawing.Point(37, 136);
            this.lblMecury.Name = "lblMecury";
            this.lblMecury.Size = new System.Drawing.Size(42, 13);
            this.lblMecury.TabIndex = 15;
            this.lblMecury.Text = "Mecury";
            // 
            // picPlanet1
            // 
            this.picPlanet1.Image = ((System.Drawing.Image)(resources.GetObject("picPlanet1.Image")));
            this.picPlanet1.Location = new System.Drawing.Point(16, 56);
            this.picPlanet1.Name = "picPlanet1";
            this.picPlanet1.Size = new System.Drawing.Size(75, 75);
            this.picPlanet1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlanet1.TabIndex = 14;
            this.picPlanet1.TabStop = false;
            this.picPlanet1.Tag = "mercury";
            this.picPlanet1.DragDrop += new System.Windows.Forms.DragEventHandler(this.PlanetPlaceHolder_DragDrop);
            this.picPlanet1.DragEnter += new System.Windows.Forms.DragEventHandler(this.PlanetPlaceHolder_DragEnter);
            // 
            // picPlanet2
            // 
            this.picPlanet2.Image = ((System.Drawing.Image)(resources.GetObject("picPlanet2.Image")));
            this.picPlanet2.Location = new System.Drawing.Point(107, 56);
            this.picPlanet2.Name = "picPlanet2";
            this.picPlanet2.Size = new System.Drawing.Size(75, 75);
            this.picPlanet2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlanet2.TabIndex = 14;
            this.picPlanet2.TabStop = false;
            this.picPlanet2.Tag = "venus";
            this.picPlanet2.DragDrop += new System.Windows.Forms.DragEventHandler(this.PlanetPlaceHolder_DragDrop);
            this.picPlanet2.DragEnter += new System.Windows.Forms.DragEventHandler(this.PlanetPlaceHolder_DragEnter);
            // 
            // lblVenus
            // 
            this.lblVenus.AutoSize = true;
            this.lblVenus.BackColor = System.Drawing.Color.Transparent;
            this.lblVenus.ForeColor = System.Drawing.Color.White;
            this.lblVenus.Location = new System.Drawing.Point(128, 136);
            this.lblVenus.Name = "lblVenus";
            this.lblVenus.Size = new System.Drawing.Size(37, 13);
            this.lblVenus.TabIndex = 15;
            this.lblVenus.Text = "Venus";
            // 
            // picPlanet3
            // 
            this.picPlanet3.Image = ((System.Drawing.Image)(resources.GetObject("picPlanet3.Image")));
            this.picPlanet3.Location = new System.Drawing.Point(199, 56);
            this.picPlanet3.Name = "picPlanet3";
            this.picPlanet3.Size = new System.Drawing.Size(75, 75);
            this.picPlanet3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlanet3.TabIndex = 14;
            this.picPlanet3.TabStop = false;
            this.picPlanet3.Tag = "earth";
            this.picPlanet3.DragDrop += new System.Windows.Forms.DragEventHandler(this.PlanetPlaceHolder_DragDrop);
            this.picPlanet3.DragEnter += new System.Windows.Forms.DragEventHandler(this.PlanetPlaceHolder_DragEnter);
            // 
            // lblEarth
            // 
            this.lblEarth.AutoSize = true;
            this.lblEarth.BackColor = System.Drawing.Color.Transparent;
            this.lblEarth.ForeColor = System.Drawing.Color.White;
            this.lblEarth.Location = new System.Drawing.Point(220, 136);
            this.lblEarth.Name = "lblEarth";
            this.lblEarth.Size = new System.Drawing.Size(32, 13);
            this.lblEarth.TabIndex = 15;
            this.lblEarth.Text = "Earth";
            // 
            // picPlanet4
            // 
            this.picPlanet4.Image = ((System.Drawing.Image)(resources.GetObject("picPlanet4.Image")));
            this.picPlanet4.Location = new System.Drawing.Point(289, 56);
            this.picPlanet4.Name = "picPlanet4";
            this.picPlanet4.Size = new System.Drawing.Size(75, 75);
            this.picPlanet4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlanet4.TabIndex = 14;
            this.picPlanet4.TabStop = false;
            this.picPlanet4.Tag = "mars";
            this.picPlanet4.DragDrop += new System.Windows.Forms.DragEventHandler(this.PlanetPlaceHolder_DragDrop);
            this.picPlanet4.DragEnter += new System.Windows.Forms.DragEventHandler(this.PlanetPlaceHolder_DragEnter);
            // 
            // picPlanet5
            // 
            this.picPlanet5.Image = ((System.Drawing.Image)(resources.GetObject("picPlanet5.Image")));
            this.picPlanet5.Location = new System.Drawing.Point(380, 56);
            this.picPlanet5.Name = "picPlanet5";
            this.picPlanet5.Size = new System.Drawing.Size(75, 75);
            this.picPlanet5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlanet5.TabIndex = 14;
            this.picPlanet5.TabStop = false;
            this.picPlanet5.Tag = "jupiter";
            this.picPlanet5.DragDrop += new System.Windows.Forms.DragEventHandler(this.PlanetPlaceHolder_DragDrop);
            this.picPlanet5.DragEnter += new System.Windows.Forms.DragEventHandler(this.PlanetPlaceHolder_DragEnter);
            // 
            // picPlanet6
            // 
            this.picPlanet6.Image = ((System.Drawing.Image)(resources.GetObject("picPlanet6.Image")));
            this.picPlanet6.Location = new System.Drawing.Point(472, 56);
            this.picPlanet6.Name = "picPlanet6";
            this.picPlanet6.Size = new System.Drawing.Size(75, 75);
            this.picPlanet6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlanet6.TabIndex = 14;
            this.picPlanet6.TabStop = false;
            this.picPlanet6.Tag = "saturn";
            this.picPlanet6.DragDrop += new System.Windows.Forms.DragEventHandler(this.PlanetPlaceHolder_DragDrop);
            this.picPlanet6.DragEnter += new System.Windows.Forms.DragEventHandler(this.PlanetPlaceHolder_DragEnter);
            // 
            // lblMars
            // 
            this.lblMars.AutoSize = true;
            this.lblMars.BackColor = System.Drawing.Color.Transparent;
            this.lblMars.ForeColor = System.Drawing.Color.White;
            this.lblMars.Location = new System.Drawing.Point(310, 136);
            this.lblMars.Name = "lblMars";
            this.lblMars.Size = new System.Drawing.Size(30, 13);
            this.lblMars.TabIndex = 15;
            this.lblMars.Text = "Mars";
            // 
            // lblJupiter
            // 
            this.lblJupiter.AutoSize = true;
            this.lblJupiter.BackColor = System.Drawing.Color.Transparent;
            this.lblJupiter.ForeColor = System.Drawing.Color.White;
            this.lblJupiter.Location = new System.Drawing.Point(401, 136);
            this.lblJupiter.Name = "lblJupiter";
            this.lblJupiter.Size = new System.Drawing.Size(38, 13);
            this.lblJupiter.TabIndex = 15;
            this.lblJupiter.Text = "Jupiter";
            // 
            // lblSaturn
            // 
            this.lblSaturn.AutoSize = true;
            this.lblSaturn.BackColor = System.Drawing.Color.Transparent;
            this.lblSaturn.ForeColor = System.Drawing.Color.White;
            this.lblSaturn.Location = new System.Drawing.Point(493, 136);
            this.lblSaturn.Name = "lblSaturn";
            this.lblSaturn.Size = new System.Drawing.Size(38, 13);
            this.lblSaturn.TabIndex = 15;
            this.lblSaturn.Text = "Saturn";
            // 
            // picPlanet7
            // 
            this.picPlanet7.Image = ((System.Drawing.Image)(resources.GetObject("picPlanet7.Image")));
            this.picPlanet7.Location = new System.Drawing.Point(564, 56);
            this.picPlanet7.Name = "picPlanet7";
            this.picPlanet7.Size = new System.Drawing.Size(75, 75);
            this.picPlanet7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlanet7.TabIndex = 14;
            this.picPlanet7.TabStop = false;
            this.picPlanet7.Tag = "uranus";
            this.picPlanet7.DragDrop += new System.Windows.Forms.DragEventHandler(this.PlanetPlaceHolder_DragDrop);
            this.picPlanet7.DragEnter += new System.Windows.Forms.DragEventHandler(this.PlanetPlaceHolder_DragEnter);
            // 
            // picPlanet8
            // 
            this.picPlanet8.Image = ((System.Drawing.Image)(resources.GetObject("picPlanet8.Image")));
            this.picPlanet8.Location = new System.Drawing.Point(656, 56);
            this.picPlanet8.Name = "picPlanet8";
            this.picPlanet8.Size = new System.Drawing.Size(75, 75);
            this.picPlanet8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlanet8.TabIndex = 14;
            this.picPlanet8.TabStop = false;
            this.picPlanet8.Tag = "neptune";
            this.picPlanet8.DragDrop += new System.Windows.Forms.DragEventHandler(this.PlanetPlaceHolder_DragDrop);
            this.picPlanet8.DragEnter += new System.Windows.Forms.DragEventHandler(this.PlanetPlaceHolder_DragEnter);
            // 
            // lblUranus
            // 
            this.lblUranus.AutoSize = true;
            this.lblUranus.BackColor = System.Drawing.Color.Transparent;
            this.lblUranus.ForeColor = System.Drawing.Color.White;
            this.lblUranus.Location = new System.Drawing.Point(585, 136);
            this.lblUranus.Name = "lblUranus";
            this.lblUranus.Size = new System.Drawing.Size(41, 13);
            this.lblUranus.TabIndex = 15;
            this.lblUranus.Text = "Uranus";
            // 
            // lblNeptune
            // 
            this.lblNeptune.AutoSize = true;
            this.lblNeptune.BackColor = System.Drawing.Color.Transparent;
            this.lblNeptune.ForeColor = System.Drawing.Color.White;
            this.lblNeptune.Location = new System.Drawing.Point(677, 136);
            this.lblNeptune.Name = "lblNeptune";
            this.lblNeptune.Size = new System.Drawing.Size(48, 13);
            this.lblNeptune.TabIndex = 15;
            this.lblNeptune.Text = "Neptune";
            // 
            // picEarth
            // 
            this.picEarth.Image = ((System.Drawing.Image)(resources.GetObject("picEarth.Image")));
            this.picEarth.Location = new System.Drawing.Point(16, 230);
            this.picEarth.Name = "picEarth";
            this.picEarth.Size = new System.Drawing.Size(75, 75);
            this.picEarth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEarth.TabIndex = 14;
            this.picEarth.TabStop = false;
            this.picEarth.Tag = "earth";
            this.picEarth.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Planet_MouseDown);
            // 
            // picNeptune
            // 
            this.picNeptune.Image = ((System.Drawing.Image)(resources.GetObject("picNeptune.Image")));
            this.picNeptune.Location = new System.Drawing.Point(107, 230);
            this.picNeptune.Name = "picNeptune";
            this.picNeptune.Size = new System.Drawing.Size(75, 75);
            this.picNeptune.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNeptune.TabIndex = 14;
            this.picNeptune.TabStop = false;
            this.picNeptune.Tag = "neptune";
            this.picNeptune.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Planet_MouseDown);
            // 
            // picMars
            // 
            this.picMars.Image = ((System.Drawing.Image)(resources.GetObject("picMars.Image")));
            this.picMars.Location = new System.Drawing.Point(289, 230);
            this.picMars.Name = "picMars";
            this.picMars.Size = new System.Drawing.Size(75, 75);
            this.picMars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMars.TabIndex = 14;
            this.picMars.TabStop = false;
            this.picMars.Tag = "mars";
            this.picMars.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Planet_MouseDown);
            // 
            // picSaturn
            // 
            this.picSaturn.Image = ((System.Drawing.Image)(resources.GetObject("picSaturn.Image")));
            this.picSaturn.Location = new System.Drawing.Point(199, 230);
            this.picSaturn.Name = "picSaturn";
            this.picSaturn.Size = new System.Drawing.Size(75, 75);
            this.picSaturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSaturn.TabIndex = 14;
            this.picSaturn.TabStop = false;
            this.picSaturn.Tag = "saturn";
            this.picSaturn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Planet_MouseDown);
            // 
            // picUranus
            // 
            this.picUranus.Image = ((System.Drawing.Image)(resources.GetObject("picUranus.Image")));
            this.picUranus.Location = new System.Drawing.Point(380, 230);
            this.picUranus.Name = "picUranus";
            this.picUranus.Size = new System.Drawing.Size(75, 75);
            this.picUranus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUranus.TabIndex = 14;
            this.picUranus.TabStop = false;
            this.picUranus.Tag = "uranus";
            this.picUranus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Planet_MouseDown);
            // 
            // picMercury
            // 
            this.picMercury.Image = ((System.Drawing.Image)(resources.GetObject("picMercury.Image")));
            this.picMercury.Location = new System.Drawing.Point(564, 230);
            this.picMercury.Name = "picMercury";
            this.picMercury.Size = new System.Drawing.Size(75, 75);
            this.picMercury.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMercury.TabIndex = 14;
            this.picMercury.TabStop = false;
            this.picMercury.Tag = "mercury";
            this.picMercury.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Planet_MouseDown);
            // 
            // picVenus
            // 
            this.picVenus.Image = ((System.Drawing.Image)(resources.GetObject("picVenus.Image")));
            this.picVenus.Location = new System.Drawing.Point(472, 230);
            this.picVenus.Name = "picVenus";
            this.picVenus.Size = new System.Drawing.Size(75, 75);
            this.picVenus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVenus.TabIndex = 14;
            this.picVenus.TabStop = false;
            this.picVenus.Tag = "venus";
            this.picVenus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Planet_MouseDown);
            // 
            // picJupiter
            // 
            this.picJupiter.Image = ((System.Drawing.Image)(resources.GetObject("picJupiter.Image")));
            this.picJupiter.Location = new System.Drawing.Point(656, 230);
            this.picJupiter.Name = "picJupiter";
            this.picJupiter.Size = new System.Drawing.Size(75, 75);
            this.picJupiter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picJupiter.TabIndex = 14;
            this.picJupiter.TabStop = false;
            this.picJupiter.Tag = "jupiter";
            this.picJupiter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Planet_MouseDown);
            // 
            // btnCheckScore
            // 
            this.btnCheckScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckScore.Location = new System.Drawing.Point(306, 373);
            this.btnCheckScore.Name = "btnCheckScore";
            this.btnCheckScore.Size = new System.Drawing.Size(134, 28);
            this.btnCheckScore.TabIndex = 17;
            this.btnCheckScore.Text = "Check Score!";
            this.btnCheckScore.UseVisualStyleBackColor = true;
            this.btnCheckScore.Click += new System.EventHandler(this.btnCheckScore_Click);
            // 
            // lblTimeTaken
            // 
            this.lblTimeTaken.AutoSize = true;
            this.lblTimeTaken.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeTaken.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeTaken.ForeColor = System.Drawing.Color.Transparent;
            this.lblTimeTaken.Location = new System.Drawing.Point(350, 327);
            this.lblTimeTaken.Name = "lblTimeTaken";
            this.lblTimeTaken.Size = new System.Drawing.Size(46, 25);
            this.lblTimeTaken.TabIndex = 18;
            this.lblTimeTaken.Text = "0:00";
            this.lblTimeTaken.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timerLevel3
            // 
            this.timerLevel3.Interval = 1000;
            this.timerLevel3.Tick += new System.EventHandler(this.timerLevel3_Tick);
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(13, 330);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(305, 23);
            this.lblScore.TabIndex = 19;
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmDragGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(749, 411);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblTimeTaken);
            this.Controls.Add(this.btnCheckScore);
            this.Controls.Add(this.lblNeptune);
            this.Controls.Add(this.lblSaturn);
            this.Controls.Add(this.lblEarth);
            this.Controls.Add(this.lblUranus);
            this.Controls.Add(this.lblJupiter);
            this.Controls.Add(this.lblVenus);
            this.Controls.Add(this.lblMars);
            this.Controls.Add(this.lblMecury);
            this.Controls.Add(this.picJupiter);
            this.Controls.Add(this.picPlanet8);
            this.Controls.Add(this.picVenus);
            this.Controls.Add(this.picPlanet6);
            this.Controls.Add(this.picMercury);
            this.Controls.Add(this.picPlanet7);
            this.Controls.Add(this.picUranus);
            this.Controls.Add(this.picSaturn);
            this.Controls.Add(this.picPlanet5);
            this.Controls.Add(this.picMars);
            this.Controls.Add(this.picPlanet3);
            this.Controls.Add(this.picNeptune);
            this.Controls.Add(this.picPlanet4);
            this.Controls.Add(this.picEarth);
            this.Controls.Add(this.picPlanet2);
            this.Controls.Add(this.picPlanet1);
            this.Controls.Add(this.lblHeaderText);
            this.Name = "frmDragGame";
            this.Text = "Level 3 - Match The Planets";
            this.Load += new System.EventHandler(this.frmDragGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPlanet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlanet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlanet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlanet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlanet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlanet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlanet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlanet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEarth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNeptune)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSaturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUranus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMercury)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVenus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJupiter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeaderText;
        private System.Windows.Forms.Label lblMecury;
        private System.Windows.Forms.PictureBox picPlanet1;
        private System.Windows.Forms.PictureBox picPlanet2;
        private System.Windows.Forms.Label lblVenus;
        private System.Windows.Forms.PictureBox picPlanet3;
        private System.Windows.Forms.Label lblEarth;
        private System.Windows.Forms.PictureBox picPlanet4;
        private System.Windows.Forms.PictureBox picPlanet5;
        private System.Windows.Forms.PictureBox picPlanet6;
        private System.Windows.Forms.Label lblMars;
        private System.Windows.Forms.Label lblJupiter;
        private System.Windows.Forms.Label lblSaturn;
        private System.Windows.Forms.PictureBox picPlanet7;
        private System.Windows.Forms.PictureBox picPlanet8;
        private System.Windows.Forms.Label lblUranus;
        private System.Windows.Forms.Label lblNeptune;
        private System.Windows.Forms.PictureBox picEarth;
        private System.Windows.Forms.PictureBox picNeptune;
        private System.Windows.Forms.PictureBox picMars;
        private System.Windows.Forms.PictureBox picSaturn;
        private System.Windows.Forms.PictureBox picUranus;
        private System.Windows.Forms.PictureBox picMercury;
        private System.Windows.Forms.PictureBox picVenus;
        private System.Windows.Forms.PictureBox picJupiter;
        private System.Windows.Forms.Button btnCheckScore;
        private System.Windows.Forms.Label lblTimeTaken;
        private System.Windows.Forms.Timer timerLevel3;
        private System.Windows.Forms.Label lblScore;
    }
}
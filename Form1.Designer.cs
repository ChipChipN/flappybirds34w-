namespace FlappyBirdStart
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Pole2 = new System.Windows.Forms.PictureBox();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.Pole1 = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.ScoreBox = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pole2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pole1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Pole2
            // 
            this.Pole2.BackColor = System.Drawing.Color.Transparent;
            this.Pole2.Image = global::FlappyBirdStart.Properties.Resources.as2;
            this.Pole2.Location = new System.Drawing.Point(733, 45);
            this.Pole2.Name = "Pole2";
            this.Pole2.Size = new System.Drawing.Size(119, 255);
            this.Pole2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pole2.TabIndex = 0;
            this.Pole2.TabStop = false;
            // 
            // flappyBird
            // 
            this.flappyBird.BackColor = System.Drawing.Color.Transparent;
            this.flappyBird.Image = global::FlappyBirdStart.Properties.Resources.Ảnh_chụp_màn_hình_2024_10_21_232757_removebg_preview;
            this.flappyBird.Location = new System.Drawing.Point(137, 228);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(76, 72);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 1;
            this.flappyBird.TabStop = false;
            // 
            // Pole1
            // 
            this.Pole1.BackColor = System.Drawing.Color.Transparent;
            this.Pole1.Image = global::FlappyBirdStart.Properties.Resources.as3;
            this.Pole1.Location = new System.Drawing.Point(416, 379);
            this.Pole1.Name = "Pole1";
            this.Pole1.Size = new System.Drawing.Size(131, 260);
            this.Pole1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pole1.TabIndex = 2;
            this.Pole1.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::FlappyBirdStart.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-3, 629);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1029, 85);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // ScoreBox
            // 
            this.ScoreBox.AutoSize = true;
            this.ScoreBox.BackColor = System.Drawing.Color.Transparent;
            this.ScoreBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreBox.ForeColor = System.Drawing.SystemColors.Window;
            this.ScoreBox.Location = new System.Drawing.Point(33, 83);
            this.ScoreBox.Name = "ScoreBox";
            this.ScoreBox.Size = new System.Drawing.Size(165, 42);
            this.ScoreBox.TabIndex = 4;
            this.ScoreBox.Text = "Score: 0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FlappyBirdStart.Properties.Resources.top;
            this.pictureBox1.Location = new System.Drawing.Point(-15, -51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1074, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(968, 708);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ScoreBox);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.Pole1);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.Pole2);
            this.Name = "Form1";
            this.Text = "Flappy Bird Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.Pole2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pole1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pole2;
        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.PictureBox Pole1;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label ScoreBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


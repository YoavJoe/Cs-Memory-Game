namespace YoavMemoryGame
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSteps = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblNumerv = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::YoavMemoryGame.Properties.Resources.back;
            this.pictureBox8.Location = new System.Drawing.Point(636, 125);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(163, 79);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 5;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox_Card_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::YoavMemoryGame.Properties.Resources.back;
            this.pictureBox6.Location = new System.Drawing.Point(280, 125);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(163, 79);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 7;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox_Card_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::YoavMemoryGame.Properties.Resources.back;
            this.pictureBox7.Location = new System.Drawing.Point(458, 125);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(163, 79);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 8;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox_Card_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::YoavMemoryGame.Properties.Resources.back;
            this.pictureBox5.Location = new System.Drawing.Point(102, 125);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(163, 79);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox_Card_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::YoavMemoryGame.Properties.Resources.back;
            this.pictureBox4.Location = new System.Drawing.Point(637, 26);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(163, 79);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox_Card_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::YoavMemoryGame.Properties.Resources.back;
            this.pictureBox3.Location = new System.Drawing.Point(458, 26);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(163, 79);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox_Card_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::YoavMemoryGame.Properties.Resources.back;
            this.pictureBox2.Location = new System.Drawing.Point(280, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(163, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox_Card_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::YoavMemoryGame.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(102, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox_Card_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(48, 26);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(156, 47);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Quit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.btnNewGame);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Location = new System.Drawing.Point(102, 268);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 100);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(228, 26);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(156, 47);
            this.btnNewGame.TabIndex = 11;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(862, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Time Left in seconds";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(858, 55);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 13);
            this.lblTime.TabIndex = 13;
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Location = new System.Drawing.Point(1009, 41);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(13, 13);
            this.lblSeconds.TabIndex = 14;
            this.lblSeconds.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(862, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Number of steps:";
            // 
            // lblSteps
            // 
            this.lblSteps.AutoSize = true;
            this.lblSteps.Location = new System.Drawing.Point(1009, 80);
            this.lblSteps.Name = "lblSteps";
            this.lblSteps.Size = new System.Drawing.Size(13, 13);
            this.lblSteps.TabIndex = 16;
            this.lblSteps.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(862, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Number of victories";
            this.label3.Click += new System.EventHandler(this.lblNumerv_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lblNumerv
            // 
            this.lblNumerv.AutoSize = true;
            this.lblNumerv.Location = new System.Drawing.Point(1009, 125);
            this.lblNumerv.Name = "lblNumerv";
            this.lblNumerv.Size = new System.Drawing.Size(13, 13);
            this.lblNumerv.TabIndex = 18;
            this.lblNumerv.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 396);
            this.Controls.Add(this.lblNumerv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSteps);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSteps;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblNumerv;
    }
}


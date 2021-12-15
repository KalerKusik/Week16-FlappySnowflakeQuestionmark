
namespace FlappyBird
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PipeBottom = new System.Windows.Forms.PictureBox();
            this.Earth = new System.Windows.Forms.PictureBox();
            this.PipeTop = new System.Windows.Forms.PictureBox();
            this.FlappyBoi = new System.Windows.Forms.PictureBox();
            this.PointsLolBox = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Earth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlappyBoi)).BeginInit();
            this.SuspendLayout();
            // 
            // PipeBottom
            // 
            this.PipeBottom.BackColor = System.Drawing.Color.Transparent;
            this.PipeBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PipeBottom.Image = ((System.Drawing.Image)(resources.GetObject("PipeBottom.Image")));
            this.PipeBottom.Location = new System.Drawing.Point(290, 324);
            this.PipeBottom.Name = "PipeBottom";
            this.PipeBottom.Size = new System.Drawing.Size(150, 174);
            this.PipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeBottom.TabIndex = 0;
            this.PipeBottom.TabStop = false;
            this.PipeBottom.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Earth
            // 
            this.Earth.BackColor = System.Drawing.Color.Transparent;
            this.Earth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Earth.Image = ((System.Drawing.Image)(resources.GetObject("Earth.Image")));
            this.Earth.Location = new System.Drawing.Point(-14, 489);
            this.Earth.Name = "Earth";
            this.Earth.Size = new System.Drawing.Size(470, 209);
            this.Earth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Earth.TabIndex = 1;
            this.Earth.TabStop = false;
            this.Earth.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // PipeTop
            // 
            this.PipeTop.Image = ((System.Drawing.Image)(resources.GetObject("PipeTop.Image")));
            this.PipeTop.Location = new System.Drawing.Point(290, -8);
            this.PipeTop.Name = "PipeTop";
            this.PipeTop.Size = new System.Drawing.Size(150, 149);
            this.PipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeTop.TabIndex = 2;
            this.PipeTop.TabStop = false;
            // 
            // FlappyBoi
            // 
            this.FlappyBoi.Image = ((System.Drawing.Image)(resources.GetObject("FlappyBoi.Image")));
            this.FlappyBoi.Location = new System.Drawing.Point(12, 144);
            this.FlappyBoi.Name = "FlappyBoi";
            this.FlappyBoi.Size = new System.Drawing.Size(64, 59);
            this.FlappyBoi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FlappyBoi.TabIndex = 3;
            this.FlappyBoi.TabStop = false;
            // 
            // PointsLolBox
            // 
            this.PointsLolBox.AutoSize = true;
            this.PointsLolBox.BackColor = System.Drawing.Color.Transparent;
            this.PointsLolBox.Location = new System.Drawing.Point(26, 52);
            this.PointsLolBox.Name = "PointsLolBox";
            this.PointsLolBox.Size = new System.Drawing.Size(103, 25);
            this.PointsLolBox.TabIndex = 4;
            this.PointsLolBox.Text = "Points lol: 0";
            this.PointsLolBox.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 553);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Play Game Xdddd";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            this.button1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.button1_KeyUp);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(262, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 154);
            this.button2.TabIndex = 6;
            this.button2.Text = "you play yes?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(450, 682);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PointsLolBox);
            this.Controls.Add(this.FlappyBoi);
            this.Controls.Add(this.PipeBottom);
            this.Controls.Add(this.Earth);
            this.Controls.Add(this.PipeTop);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Earth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlappyBoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PipeBottom;
        private System.Windows.Forms.PictureBox Earth;
        private System.Windows.Forms.PictureBox PipeTop;
        private System.Windows.Forms.PictureBox FlappyBoi;
        private System.Windows.Forms.Label PointsLolBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}


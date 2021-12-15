using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        int gravity = 10;
        int garfieldPipeSpeed = 6;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            FlappyBoi.Top += gravity;
            PipeTop.Left -= garfieldPipeSpeed;
            PipeBottom.Left -= garfieldPipeSpeed;
            PointsLolBox.Text = $"Points lol: {score}"; 

            if(PipeTop.Left < -80)
            {
                PipeTop.Left = 500;
                PipeBottom.Left = 500;
                score++;
            }

            if (FlappyBoi.Bounds.IntersectsWith(PipeTop.Bounds) || FlappyBoi.Bounds.IntersectsWith(PipeBottom.Bounds) || FlappyBoi.Bounds.IntersectsWith(Earth.Bounds))
            {
                birbDie();
            }

            if(FlappyBoi.Top < -25)
            {
                birbDie();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space) 
            {
                gravity = -5;
            }   
        }

        private void button1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }
        private void birbDie()
        {
            timer1.Stop();
            PointsLolBox.Text = $"You are die lol";
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);
        }
    }
}

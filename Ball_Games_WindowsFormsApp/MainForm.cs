using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ball_Games_WindowsFormsApp
{
    public partial class MainForm : Form
    {
        BallRandomSizable ballRandomSizable;
        BallRandom ballRandom;
        Ball ball;
        public List<BallRandomSizable> list;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ball = new Ball(this);
            ball.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ballRandom = new BallRandom(this);
            ballRandom.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.White;
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            BallRandomMouseClick ballRandomMouseClick = new BallRandomMouseClick(this, e.X, e.Y);
            ballRandomMouseClick.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            list = new List<BallRandomSizable>();
            for (int i = 0; i < 10; i++)
            {
                ballRandomSizable = new BallRandomSizable(this);
                list.Add(ballRandomSizable);
                ballRandomSizable.Show();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            BallRandomSizable ballRandomSizable = new BallRandomSizable(this);
            ballRandomSizable.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (list != null)
            {
                foreach (var i in list)
                {
                    i.Clear();
                    i.Move();
                    i.Show();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer.Stop();
            var Catched = ballRandomSizable.CheckLocations();
            label1.Text = $"Поймано {Catched}";
        }
    }
}

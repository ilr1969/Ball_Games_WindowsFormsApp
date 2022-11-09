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

        private void Button1_Click(object sender, EventArgs e)
        {
            ball = new Ball(this);
            ball.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ballRandom = new BallRandom(this);
            ballRandom.Show();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.White;
/*            foreach (var i in list)
            {
                i.Clear();
            }*/
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            BallRandomMouseClick ballRandomMouseClick = new BallRandomMouseClick(this, e.X, e.Y);
            ballRandomMouseClick.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            CreateBalls();
        }

        private void CreateBalls()
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

        private void Button4_Click(object sender, EventArgs e)
        {
            CreateBalls();
            timer.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
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

        private void Button5_Click(object sender, EventArgs e)
        {
            timer.Stop();
            var Catched = ballRandomSizable.CheckLocations();
            label1.Text = $"Поймано {Catched}";
        }
    }
}

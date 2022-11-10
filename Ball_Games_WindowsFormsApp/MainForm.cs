using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Ball_Class;

namespace BallClass
{
    public partial class MainForm : Form
    {
        BallRandomSizable ballRandomSizable;
        BallRandom ballRandom;
        Ball ball;
        MoveBall moveBall;
        public List<MoveBall> list = new List<MoveBall>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            button5.Enabled = false;
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
            foreach (var i in list)
            {
                i.Clear();
            }
            list.Clear();
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
            for (int i = 0; i < 10; i++)
            {
                ballRandomSizable = new BallRandomSizable(this);
                ballRandomSizable.Move();
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
            
            button5.Enabled = true;
            button4.Enabled = false;
            for (int i = 0; i < 10; i++)
            {
                moveBall = new MoveBall(this);
                list.Add(moveBall);
                moveBall.Start();
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;
            button5.Enabled = false;
            for (int i= 0; i < list.Count; i++)
            {
                list[i].Stop();
            }
            var Catched = moveBall.CheckLocations(list);
            label1.Text = $"Поймано {Catched}";
        }
    }
}

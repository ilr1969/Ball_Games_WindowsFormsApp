using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Ball_Class;

namespace Diffusion_WindowsFormsApp
{
    public partial class MainForm : Form
    {
        Diffusion diffusion;
        List<Ball> list = new List<Ball>();
        int t = 0;
        Timer timer = new Timer();

        public MainForm()
        {
            InitializeComponent();
            timer.Interval = 10;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CreateDiffusionBallsRight(0, ClientSize.Width / 2);
            CreateDiffusionBallsLeft(ClientSize.Width / 2, ClientSize.Width);
        }

        public void DrawLine()
        {
            var graphics = CreateGraphics();
            graphics.DrawLine(Pens.Black, ClientSize.Width / 2, 0, ClientSize.Width / 2, ClientSize.Width);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DrawLine();
            if (diffusion.CheckSide(list))
            {
                foreach (var i in list)
                {
                    i.Stop();
                }
            }
        }

        private void CreateDiffusionBallsRight(int StartPos, int EndPos)
        {
            for (int i = 0; i < 10; i++)
            {
                diffusion = new Diffusion(this, StartPos, EndPos);
                diffusion.onHited += Diffusion_onHited1;
                list.Add(diffusion);
                diffusion.Start();
            }
        }

        private void CreateDiffusionBallsLeft(int StartPos, int EndPos)
        {
            for (int i = 0; i < 10; i++)
            {
                diffusion = new Diffusion(this, StartPos, EndPos);
                diffusion.onHited += Diffusion_onHited2;
                list.Add(diffusion);
                diffusion.Start();
            }
        }

        private void Diffusion_onHited1(object sender, HitEventArgs e)
        {
            switch (e.side)
            {
                case BylliardBall.Side.Left:
                    LeftRedLabel.Text = (Convert.ToInt32(LeftRedLabel.Text) + 1).ToString();
                    break;
                case BylliardBall.Side.Right:
                    RightRedLabel.Text = (Convert.ToInt32(RightRedLabel.Text) + 1).ToString();
                    break;
                case BylliardBall.Side.Top:
                    TopRedLabel.Text = (Convert.ToInt32(TopRedLabel.Text) + 1).ToString();
                    break;
                case BylliardBall.Side.Down:
                    DownRedLabel.Text = (Convert.ToInt32(DownRedLabel.Text) + 1).ToString();
                    break;
                default:
                    break;
            }
        }

        private void Diffusion_onHited2(object sender, HitEventArgs e)
        {
            switch (e.side)
            {
                case BylliardBall.Side.Left:
                    LeftGreenLabel.Text = (Convert.ToInt32(LeftGreenLabel.Text) + 1).ToString();
                    break;
                case BylliardBall.Side.Right:
                    RightGreenLabel.Text = (Convert.ToInt32(RightGreenLabel.Text) + 1).ToString();
                    break;
                case BylliardBall.Side.Top:
                    TopGreenLabel.Text = (Convert.ToInt32(TopGreenLabel.Text) + 1).ToString();
                    break;
                case BylliardBall.Side.Down:
                    DownGreenLabel.Text = (Convert.ToInt32(DownGreenLabel.Text) + 1).ToString();
                    break;
                default:
                    break;
            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (t == 0)
            {
                foreach (var i in list)
                {
                    i.Stop();
                }
                t=1;
            }

            else
            {
                foreach (var i in list)
                if (t == 1)
                {
                    i.Start();
                }
                t=0;
            }
        }
    }
}

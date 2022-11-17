using System;
using System.Windows.Forms;

namespace Salut_WindowsFormsApp
{
    public partial class MainForm : Form
    {
        BallSalut ballSalut;
        BallSalut ballSalutStart;
        Timer timer = new Timer();
        public MainForm()
        {
            InitializeComponent();
            timer.Interval = 10;
            timer.Tick += Timer_Tick;
        }
        
        private void Timer_Tick(object sender, EventArgs e)
        {
            CheckTopPosition(ballSalutStart);
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            StartSalut(e.X, e.Y);
        }

        private void StartSalut(int x, int y)
        {
            for (int i = 0; i < 15; i++)
            {
                ballSalut = new BallSalut(this, x, y);
                ballSalut.Start();
            }
        }

        private void SalutButton1_Click(object sender, EventArgs e)
        {
            ballSalutStart = new BallSalut(this);
            ballSalutStart.Start();
            timer.Start();
        }

        private void CheckTopPosition(BallSalut ballSalutStart)
        {
            if (ballSalutStart.ySpeed < 1 && ballSalutStart.ySpeed > -1)
            {
                ballSalutStart.Stop();
                timer.Stop();
                StartSalut((int)ballSalutStart.xPos, (int)ballSalutStart.yPos);
                ballSalutStart.Clear();
            }
        }
    }
}

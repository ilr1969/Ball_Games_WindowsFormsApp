using System;
using System.Windows.Forms;

namespace Salut_WindowsFormsApp
{
    public partial class MainForm : Form
    {
        BallSalut ballSalut;
        BallSalutStart ballSalutStart;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            StartSalut(e.X, e.Y);
        }

        private void StartSalut(int x, int y)
        {
            for (int i = 0; i < 2; i++)
            {
                ballSalut = new BallSalut(this, x, y);
                ballSalut.Start();
            }
        }

        private void SalutButton1_Click(object sender, EventArgs e)
        {
            ballSalutStart = new BallSalutStart(this);
            ballSalutStart.TopReached += ballSalutStart_TopReached;
            ballSalutStart.Start();
            
        }

        private void ballSalutStart_TopReached(object sender, TopReachedEventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                ballSalut = new BallSalut(this, e.xPos, e.yPos);
                ballSalut.Start();
            }
        }
    }
}

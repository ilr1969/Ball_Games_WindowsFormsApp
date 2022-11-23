using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Fruit_Ninja_WindowsFormsApp
{
    public partial class MainForm : Form
    {
        List<FruitNinja> list = new List<FruitNinja>();
        Timer timer = new Timer();
        Timer timerForSlowMotion = new Timer();
        FruitNinja fruitNinja;
        Random random = new Random();
        private int Interval = 30;
        public MainForm()
        {
            InitializeComponent();
            timer.Interval = random.Next(1000, 3000);
            timer.Tick += Timer_Tick;
            timer.Start();
            timerForSlowMotion.Interval = 5000;
            timerForSlowMotion.Tick += TimerForSlowMotion_Tick;
        }

        private void TimerForSlowMotion_Tick(object sender, EventArgs e)
        {
            Interval = 30;
            timerForSlowMotion.Stop();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                fruitNinja = new FruitNinja(this);
                fruitNinja.timer.Interval = Interval;
                list.Add(fruitNinja);
                fruitNinja.Start();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_MouseMove11(object sender, MouseEventArgs e)
        {
            CutFruit(e);
        }

        private void CutFruit(MouseEventArgs e)
        {
            foreach (var i in list)
            {
                if (i.CheckMove() && i.CheckCatched(e.X, e.Y))
                {
                    ScoreLabel.Text = (Convert.ToInt32(ScoreLabel.Text) + 1).ToString();
                    CheckYellowBall(i);
                    if (i.brush == Brushes.Black)
                    {
                        timer.Stop();
                        foreach (var j in list)
                        {
                            j.Stop();
                            j.Clear();
                        }
                        list.Clear();
                        MessageBox.Show("Бабах!!!");
                        break;
                    }
                    i.Stop();
                    i.Clear();
                }
                if (i.yPos > ClientSize.Height + i.Radius)
                {
                    i.Stop();
                    i.Clear();
                }
            }
        }

        private void CheckYellowBall(FruitNinja i)
        {
            if (i.brush == Brushes.Yellow)
            {
                foreach (var j in list)
                {
                    j.timer.Interval = 50;
                }
                Interval = 50;
                timerForSlowMotion.Start();
            }
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            CutFruit(e);
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}

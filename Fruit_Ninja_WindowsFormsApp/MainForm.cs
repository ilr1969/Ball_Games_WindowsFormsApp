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
        public MainForm()
        {
            InitializeComponent();
            timer.Interval = 500;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            FruitNinja fruitNinja = new FruitNinja(this);
            list.Add(fruitNinja);
            fruitNinja.Start();
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
                if (i.CheckCatched(e.X, e.Y))
                {
                    //ScoreLabel.Text = (Convert.ToInt32(ScoreLabel.Text) + 1).ToString();
                    i.Stop();
                    i.Clear();
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
                }
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

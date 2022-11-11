using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Ball_Class;

namespace Ball_Catch_WindowsFormsApp
{
    public partial class MainForm : Form
    {
        private List<Ball> list = new List<Ball>();
        MoveBall moveBall;
        int Catched = 0;
        public MainForm()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                moveBall = new MoveBall(this);
                list.Add(moveBall);
                moveBall.Start();
            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            foreach (var i in list)
            {
                i.Stop();
                i.Clear();
            }
            list.Clear();
            label1.Text = "Поймано: ";
            Catched = 0;
        }
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (var i in list)
            {
                if (i.CheckMove() && i.CheckCatched(e.X, e.Y))
                {
                    i.Stop();
                    Catched++;
                }
                label1.Text = $"Поймано: {Catched}";
            }
        }
    }
}

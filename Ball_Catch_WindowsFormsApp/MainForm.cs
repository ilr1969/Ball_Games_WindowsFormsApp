using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Ball_Class;

namespace Ball_Catch_WindowsFormsApp
{
    public partial class MainForm : Form
    {
        private List<MoveBall> list = new List<MoveBall>();
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

        private void timer_tick()
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

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            MoveBall moveball = new MoveBall(this);
            if (moveball.CheckCatched(list, e.X, e.Y))
            {
                Catched++;
            }
            label1.Text = $"Поймано: {Catched}";
        }
    }
}

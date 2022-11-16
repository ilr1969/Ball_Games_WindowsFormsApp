using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Ball_Class;

namespace Bylliard_WindowsFormsApp
{
    public partial class MainForm : Form
    {
        BylliardBall bylliardBall;
        List<Ball> list = new List<Ball>();
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 15; i++)
            {
                bylliardBall = new BylliardBall(this);
                list.Add(bylliardBall);
                bylliardBall.Start();
            }
        }
    }
}

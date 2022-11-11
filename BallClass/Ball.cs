using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Ball_Class
{
    public class Ball
    {
        public Form form;
        public int xPos = 150;
        public int yPos = 150;
        public Timer timer = new Timer();
        protected int xSpeed = 1;
        protected int ySpeed = 1;
        public int Radius = 50;
        protected static Random random = new Random();
        
        public Ball(Form form)
        {
            this.form = form;
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
        }
        public void Draw(Brush brush)
        {
            var graphics = form.CreateGraphics();
            var figure = new Rectangle(xPos - Radius, yPos - Radius, Radius, Radius);
            graphics.FillEllipse(brush, figure);
        }
        public void Show()
        {
            var brush = Brushes.LimeGreen;
            Draw(brush);
        }
        public virtual void Move()
        {
            xPos += xSpeed;
            yPos += ySpeed;
        }
        public void Clear()
        {
            var brush = Brushes.White;
            Draw(brush);
        }
        public int CheckLocations(List<MoveBall> list)
        {
            int result = 0;
            foreach (var i in list)
            {
                if (form.ClientSize.Width - i.Radius / 2 >= i.xPos && i.Radius / 2 <= i.xPos && form.ClientSize.Height - i.Radius / 2 >= i.yPos && i.Radius / 2 <= i.yPos)
                {
                    result++;
                }
            }
            return result;
        }
        public bool CheckCatched(int x, int y)
        {
            if ((xPos - x) * (xPos - x) + (yPos - y) * (yPos - y) <= Radius * Radius)
            {
                return true;
            }
            return false;
        }

        public void Timer_Tick(object sender, System.EventArgs e)
        {
            Clear();
            Move();
            Show();
        }

        public void Start()
        {
            timer.Enabled = true;
        }

        public void Stop()
        {
            timer.Enabled = false;
        }

        public bool CheckMove()
        {
            return timer.Enabled;
        }
    }
}
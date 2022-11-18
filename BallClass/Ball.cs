using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Ball_Class
{
    public class Ball
    {
        public Form form;
        public float xPos = 150;
        public float yPos = 150;
        public Timer timer = new Timer();
        protected float xSpeed = 1;
        public float ySpeed = 1;
        public int Radius = 50;
        protected static Random random = new Random();
        public Brush brush = Brushes.LimeGreen;
        
        public Ball(Form form)
        {
            this.form = form;
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
        }
        public virtual void Draw(Brush brush)
        {
            var graphics = form.CreateGraphics();
            var figure = new RectangleF(xPos - Radius, yPos - Radius, Radius, Radius);
            graphics.FillEllipse(brush, figure);
        }
        public void Show()
        {
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

        public bool CheckSide(List<Ball> list)
        {
            int resultRedLeft = 0;
            int resultLimeLeft = 0;
            int resultRedRight = 0;
            int resultLimeRight = 0;

            foreach (var i in list)
            {
                if (i.LeftOfCenter() && i.brush == Brushes.Red)
                {
                    resultRedLeft++;
                }
                else if (i.LeftOfCenter() && i.brush == Brushes.LimeGreen)
                {
                    resultLimeLeft++;
                }
                else if (i.RightOfCenter() && i.brush == Brushes.Red)
                {
                    resultRedRight++;
                }
                else if (i.RightOfCenter() && i.brush == Brushes.LimeGreen)
                {
                    resultLimeRight++;
                }
            }
            return resultRedLeft == resultRedRight && resultLimeLeft == resultLimeRight;
        }

        private bool LeftOfCenter()
        {
            return xPos < form.ClientSize.Width / 2 - Radius;
        }

        private bool RightOfCenter()
        {
            return xPos > form.ClientSize.Width / 2 + Radius;
        }

        public bool CheckCatched(int x, int y)
        {
            if ((xPos - x - Radius / 2) * (xPos - x - Radius / 2) + (yPos - y - Radius / 2) * (yPos - y - Radius / 2) <= Radius / 2 * Radius / 2)
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
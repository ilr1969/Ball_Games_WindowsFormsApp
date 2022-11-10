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
        protected int xSpeed = 1;
        protected int ySpeed = 1;
        public int Size = 50;
        protected static Random random = new Random();
        public Ball(Form form)
        {
            this.form = form;
        }
        public void Show()
        {
            var graphics = form.CreateGraphics();
            var brush = Brushes.LimeGreen;
            var figure = new Rectangle(xPos, yPos, Size, Size);
            graphics.FillEllipse(brush, figure);
        }
        public void Move()
        {
            xPos += xSpeed;
            yPos += ySpeed;
        }
        public void Clear()
        {
            var graphics = form.CreateGraphics();
            var brush = Brushes.White;
            var figure = new Rectangle(xPos, yPos, Size, Size);
            graphics.FillEllipse(brush, figure);
        }
        public int CheckLocations(List<MoveBall> list)
        {
            int result = 0;
            foreach (var i in list)
            {
                if (form.ClientSize.Width - i.Size / 2 >= i.xPos && i.Size / 2 <= i.xPos && form.ClientSize.Height - i.Size / 2 >= i.yPos && i.Size / 2 <= i.yPos)
                {
                    result++;
                }
            }
            return result;
        }
        public bool CheckCatched(List<MoveBall> list, int x, int y)
        {
            foreach (var i in list)
            {
                if ((i.xPos - x) * (i.xPos - x) + (i.yPos - y) * (i.yPos - y) <= i.Size * i.Size)
                {
                    i.Stop();
                    return true;
                }
            }
            return false;
        }
    }
}
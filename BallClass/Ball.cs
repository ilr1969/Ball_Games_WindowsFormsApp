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
        public bool CheckCatched(int x, int y)
        {
            if ((xPos - x) * (xPos - x) + (yPos - y) * (yPos - y) <= Size * Size)
            {
                return true;
            }
            return false;
        }
    }
}
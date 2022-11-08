using System;
using System.Drawing;

namespace Ball_Games_WindowsFormsApp
{
    public class Ball
    {
        public MainForm form;
        protected int xPos = 150;
        protected int yPos = 150;
        protected int Size = 50;
        protected static Random random = new Random();
        public Ball(MainForm form)
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
            xPos += 1;
            yPos += 1;
        }
        public void Clear()
        {
            var graphics = form.CreateGraphics();
            var brush = Brushes.White;
            var figure = new Rectangle(xPos, yPos, Size, Size);
            graphics.FillEllipse(brush, figure);
        }
        public int CheckLocations()
        {
            var list = form.list;
            int result = 0;
            foreach (var i in list)
            {
                var r = form.Size.Width - i.Size / 2;
                var t = form.Size.Height - i.Size / 2;
                if (form.Size.Width - i.Size/2 >= i.yPos && i.Size / 2 <= i.yPos && form.Size.Height - i.Size / 2 >= i.xPos && i.Size / 2 <= i.xPos)
                {
                    result++;
                }
            }
            return result;
        }
    }
}
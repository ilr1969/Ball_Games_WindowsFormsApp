using System;
using System.Windows.Forms;
using System.Drawing;
using Ball_Class;

namespace Salut_WindowsFormsApp
{
    class BallSalut : MoveBall
    {
        public float g = 0.1F;
        public BallSalut(Form form, int x, int y) : base(form)
        {
            Radius = 20;
            xPos = x + Radius / 2;
            yPos = y + Radius / 2;
            xSpeed /= 4;
            ySpeed = -Math.Abs(ySpeed) / 2;
            brush = new SolidBrush(Color.FromArgb(random.Next(255), random.Next(255), random.Next(255)));
        }
        public BallSalut(Form form) : base(form)
        {
            Radius = 20;
            yPos = form.ClientSize.Height;
            xSpeed = 0;
            ySpeed = random.Next(-8, -3);
        }
        public override void Move()
        {
            base.Move();
            ySpeed += g;
        }
    }
}

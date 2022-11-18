using System;
using System.Drawing;
using System.Windows.Forms;
using Ball_Class;

namespace Salut_WindowsFormsApp
{
    public class BallSalut : MoveBall
    {
        public float g = 0.1F;

        public BallSalut(Form form, float x, float y) : base(form)
        {
            Radius = 20;
            xPos = x + Radius / 2;
            yPos = y + Radius / 2;
            xSpeed /= 4;
            ySpeed = -Math.Abs(ySpeed) / 2;
            brush = new SolidBrush(Color.FromArgb(random.Next(255), random.Next(255), random.Next(255)));
        }
        public override void Move()
        {
            base.Move();
            ySpeed += g;
        }
    }
}

using System;
using System.Windows.Forms;
using Ball_Class;

namespace Salut_WindowsFormsApp
{
    class BallSalut : MoveBall
    {
        public float g = 0.4F;
        public BallSalut(Form form, int x, int y) : base(form)
        {
            Radius = 20;
            xPos = x + Radius / 2;
            yPos = y + Radius / 2;
            ySpeed = -Math.Abs(ySpeed);
        }
        public override void Move()
        {
            base.Move();
            ySpeed += g;
        }
    }
}

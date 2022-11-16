using System;
using System.Windows.Forms;

namespace Ball_Class
{
    public partial class BylliardBall : MoveBall
    {
        public BylliardBall(Form form) : base(form)
        {
            Radius = 20;
        }

        public event EventHandler<HitEventArgs> onHited;


        public override void Move()
        {
            base.Move();
            if (xPos - Radius <= 0)
            {
                xSpeed = -xSpeed;
                onHited.Invoke(this, new HitEventArgs(Side.Left));
            }
            if (yPos - Radius <= 0)
            {
                ySpeed = -ySpeed;
                onHited.Invoke(this, new HitEventArgs(Side.Top));
            }
            if (xPos >= form.ClientSize.Width)
            {
                xSpeed = -xSpeed;
                onHited.Invoke(this, new HitEventArgs(Side.Right));
            }
            if (yPos >= form.ClientSize.Height)
            {
                ySpeed = -ySpeed;
                onHited.Invoke(this, new HitEventArgs(Side.Down));
            }
        }
    }
}

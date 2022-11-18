using System;
using System.Windows.Forms;

namespace Salut_WindowsFormsApp
{
    public class BallSalutStart : BallSalut
    {
        public event EventHandler<TopReachedEventArgs> TopReached;
        public BallSalutStart(Form form) : base(form, form.ClientSize.Width / 2, form.ClientSize.Height)
        {
            xSpeed = 0;
            ySpeed = random.Next(-8, -3);
        }
        public override void Move()
        {
            base.Move();
            if (ySpeed > 0)
            {
                Stop();
                Clear();
                TopReached.Invoke(this, new TopReachedEventArgs(xPos, yPos));
            }
        }
    }
}

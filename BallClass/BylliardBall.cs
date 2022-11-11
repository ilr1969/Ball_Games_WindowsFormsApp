using System.Drawing;
using System.Windows.Forms;

namespace Ball_Class
{
    public class BylliardBall : MoveBall
    {
        public BylliardBall(Form form) : base(form)
        {

        }
        public override void Move()
        {
            base.Move();
            if (xPos - Radius <= 0 || xPos >= form.ClientSize.Width)
            {
                xSpeed = -xSpeed;
            }
            if (yPos - Radius <= 0 || yPos >= form.ClientSize.Height)
            {
                ySpeed = -ySpeed;
            }
        }
    }
}

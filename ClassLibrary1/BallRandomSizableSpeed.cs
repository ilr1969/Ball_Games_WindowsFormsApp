using System.Windows.Forms;

namespace Ball_Class
{
    public class BallRandomSizableSpeed : BallRandomSizable
    {
        public BallRandomSizableSpeed(Form form) : base(form)
        {
            xSpeed += random.Next(-5, 5);
            ySpeed += random.Next(-5, 5);
        }
    }
}
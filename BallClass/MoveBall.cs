using System.Windows.Forms;

namespace Ball_Class
{

    public class MoveBall : BallRandomSizable
    {
        public MoveBall(Form form) : base(form)
        {
            xSpeed = random.Next(-10, 10);
            ySpeed = random.Next(-10, 10);
        }
    }
}

using System.Windows.Forms;

namespace Ball_Class
{
    public class MoveBall : BallRandomSizableSpeed
    {
        public MoveBall(Form form) : base(form)
        {
            xSpeed += random.Next(-10, 10);
            xSpeed += random.Next(-10, 10);
        }
    }
}

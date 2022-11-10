using System.Windows.Forms;

namespace Ball_Class
{
    public class BallRandomMouseClick : BallRandomSizable
    {
        public BallRandomMouseClick(Form form, int x, int y) : base(form)
        {
            xPos = x - Size / 2;
            yPos = y - Size / 2;
        }
    }
}
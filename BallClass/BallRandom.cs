using System.Windows.Forms;
using Ball_Class;

namespace BallClass
{
    public class BallRandom : Ball
    {
        public BallRandom(Form form) : base(form)
        {
            xPos = random.Next(0, 600);
            yPos = random.Next(0, 400);
        }
    }
}
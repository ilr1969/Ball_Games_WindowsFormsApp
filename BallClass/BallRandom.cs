using System.Windows.Forms;
using Ball_Class;

namespace BallClass
{
    public class BallRandom : Ball
    {
        public BallRandom(Form form) : base(form)
        {
            xPos = random.Next(0 + Radius, form.ClientSize.Width - Radius);
            yPos = random.Next(0 + Radius, form.ClientSize.Height - Radius);
        }
    }
}
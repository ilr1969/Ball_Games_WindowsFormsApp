using System.Drawing;
using System.Windows.Forms;
using BallClass;

namespace Ball_Class
{
    public class Diffusion : BylliardBall
    {
        public Diffusion(Form form, int StartPos, int EndPos) : base(form)
        {
            xPos = random.Next(StartPos + Radius, EndPos - Radius);
            if (xPos < form.ClientSize.Width / 2)
            {
                brush = Brushes.Red;
            }
        }
    }
}

using System.Windows.Forms;
using BallClass;

namespace Ball_Class
{
    public class BallRandomSizable : BallRandom
    {
        public BallRandomSizable(Form form) : base(form)
        {
            Radius = random.Next(10, 50);
        }
        
    }
}
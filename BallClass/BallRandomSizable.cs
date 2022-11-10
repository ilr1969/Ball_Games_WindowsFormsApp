using System.Windows.Forms;
using BallClass;

namespace Ball_Class
{
    public class BallRandomSizable : BallRandom
    {
        public BallRandomSizable(Form form) : base(form)
        {
            Size = random.Next(20, 80);
        }
        
    }
}
using static Ball_Class.BylliardBall;

namespace Ball_Class
{
    public class HitEventArgs
    {
        public Side side;
        public HitEventArgs(Side side)
        {
            this.side = side;
        }
    }
}

using System.Windows.Forms;

namespace Ball_Class
{
    public class MoveBall : BallRandomSizableSpeed
    {
        private Timer timer;

        public MoveBall(Form form) : base(form)
        {
            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, System.EventArgs e)
        {
            Clear();
            Move();
            Show();
        }

        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }
    }
}

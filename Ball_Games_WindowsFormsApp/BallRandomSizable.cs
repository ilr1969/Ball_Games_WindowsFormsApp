namespace Ball_Games_WindowsFormsApp
{
    public class BallRandomSizable : BallRandom
    {
        public BallRandomSizable(MainForm form) : base(form)
        {
            Size = random.Next(20, 80);
        }
        
    }
}
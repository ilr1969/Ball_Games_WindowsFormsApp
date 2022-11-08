namespace Ball_Games_WindowsFormsApp
{
    public class BallRandom : Ball
    {
        public BallRandom(MainForm form) : base(form)
        {
            xPos = random.Next(0, 600);
            yPos = random.Next(0, 400);
        }
    }
}
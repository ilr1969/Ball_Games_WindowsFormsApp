namespace Ball_Games_WindowsFormsApp
{
    public class BallRandomMouseClick : BallRandomSizable
    {
        public BallRandomMouseClick(MainForm form, int x, int y) : base(form)
        {
            xPos = x - Size / 2;
            yPos = y - Size / 2;
        }
    }
}
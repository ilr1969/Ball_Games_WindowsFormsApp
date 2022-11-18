namespace Salut_WindowsFormsApp
{
    public class TopReachedEventArgs
    {
        public float xPos;
        public float yPos;

        public TopReachedEventArgs(float xPos, float yPos)
        {
            this.xPos = xPos;
            this.yPos = yPos;
        }
    }
}
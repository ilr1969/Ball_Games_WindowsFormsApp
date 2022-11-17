using System.Drawing;
using System.Windows.Forms;
using Ball_Class;

namespace Fruit_Ninja_WindowsFormsApp
{
    class FruitNinja : MoveBall
    {
        float g = 1F;
        int randBomb;
        public FruitNinja(Form form) : base(form)
        {
            xSpeed /= 2;
            ySpeed = random.Next(-30, -15);
            yPos = form.ClientSize.Height + Radius;
            randBomb = random.Next(1, 100);
            if (randBomb < 15)
            {
                brush = Brushes.Black;
            }
            else
            {
                brush = new SolidBrush(Color.FromArgb(random.Next(255), random.Next(255), random.Next(255)));
            }
        }
        public override void Move()
        {
            base.Move();
            ySpeed += g;
        }
    }
}

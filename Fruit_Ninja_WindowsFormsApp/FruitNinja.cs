using System.Drawing;
using System.Windows.Forms;
using Ball_Class;

namespace Fruit_Ninja_WindowsFormsApp
{
    class FruitNinja : MoveBall
    {
        float g = 1F;
        public FruitNinja(Form form) : base(form)
        {
            xSpeed /= 2;
            ySpeed = random.Next(-30, -15);
            yPos = form.ClientSize.Height + Radius;
            brush = new SolidBrush(Color.FromArgb(random.Next(255), random.Next(255), random.Next(255)));
            if (brush == Brushes.Black)
            {
                brush = Brushes.Red;
            }
        }
        public override void Move()
        {
            base.Move();
            ySpeed += g;
        }
    }
}

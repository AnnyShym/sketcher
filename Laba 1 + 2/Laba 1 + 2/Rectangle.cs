using System.Drawing;

namespace Laba_1___2
{
    public class Rectangle : Figure
    {

        private int width, height;

        public Rectangle(int x1, int y1, int width, int height) : base(x1, y1)
        {
            this.width = width;
            this.height = height;
        }

        public override void Draw(Graphics graphics, Pen pen)
        {
            graphics.DrawRectangle(pen, point1.X, point1.Y, width, height);
        }

    }
}

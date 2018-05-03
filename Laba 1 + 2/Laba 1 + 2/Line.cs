using System.Drawing;

namespace Laba_1___2
{
    public class Line : Figure
    {

        private Point point2;

        public Line(int x1, int y1, int x2, int y2) : base(x1, y1)
        {
            point2 = new Point(x2, y2);
        }

        public override void Draw(Graphics graphics, Pen pen)
        {
            graphics.DrawLine(pen, point1, point2);
        }

    }
}

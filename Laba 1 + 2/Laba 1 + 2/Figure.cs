using System.Drawing;

namespace Laba_1___2
{
    public abstract class Figure
    {

        protected Point point1;
        protected Pen pen;

        public Figure(int x1, int y1, Pen pen)
        {
            point1 = new Point(x1, y1);
            this.pen = pen;
        }

        public abstract void Draw(Graphics graphics);

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Laba_1___2
{
     class Triangle : Figure
     {

          Point point2;
          Point point3;

          public Triangle(int x1, int y1, int x2, int y2, int x3, int y3) : base(x1, y1)
          {
               point2 = new Point(x2, y2);
               point3 = new Point(x3, y3);
          }

          public override void Draw()
          {
               fMain.graphics.DrawLine(fMain.pen, point1, point2);
               fMain.graphics.DrawLine(fMain.pen, point2, point3);
               fMain.graphics.DrawLine(fMain.pen, point1, point3);
          }

     }
}

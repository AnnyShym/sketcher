using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Laba_1___2
{
     class Line : Figure
     {

          Point point2;

          public Line(int x1, int y1, int x2, int y2) : base(x1, y1)
          {
               point2 = new Point(x2, y2);
          }

          public override void Draw()
          {
               fMain.graphics.DrawLine(fMain.pen, point1, point2);
          }

     }
}

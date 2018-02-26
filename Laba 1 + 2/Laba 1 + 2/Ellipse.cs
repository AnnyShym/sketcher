using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1___2
{
     public class Ellipse : Figure
     {

          int width, height;

          public Ellipse(int x1, int y1, int width, int height) : base(x1, y1)
          {
               this.width = width;
               this.height = height;
          }

          public override void Draw()
          {
               fMain.graphics.DrawEllipse(fMain.pen, point1.X, point1.Y, width, height);
          }

     }
}

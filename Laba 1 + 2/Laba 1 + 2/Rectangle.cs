using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1___2
{
     public class Rectangle : Figure
     {

          int width, height;

          public Rectangle(int x1, int y1, int width, int height) : base(x1, y1)
          {
               this.width = width;
               this.height = height;
          }

          public override void Draw()
          {
               fMain.graphics.DrawRectangle(fMain.pen, point1.X, point1.Y, width, height);
          }

     }
}

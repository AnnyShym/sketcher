using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Laba_1___2
{
     public abstract class Figure
     {

          protected Point point1;

          public Figure(int x1, int y1)
          {
               point1 = new Point(x1, y1);
          }

          public virtual void Draw() { }

     }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1___2
{
     static class ListOfFigures
     {

          static List<Figure> list = new List<Figure>();

          public static void AddFigure(Figure figure)
          {
               list.Add(figure);
          }

          public static List<Figure> Expand()
          {
               return list;
          }

     }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_1___2
{
     public partial class fMain : Form
     {

          public static Bitmap bitmap;
          public static Graphics graphics;
          public static Pen pen;

          public fMain()
          {
               InitializeComponent();
               InitializeDrawingArea();
               ShowFigures();
          }

          private void InitializeDrawingArea()
          {
               bitmap = new Bitmap(pbSketchingArea.Width, pbSketchingArea.Height);
               graphics = Graphics.FromImage(bitmap);
               pen = new Pen(Color.DarkRed);
          }

          private void ShowFigures()
          {

               ListOfFigures.AddFigure(new Line(100, 200, 250, 200));
               ListOfFigures.AddFigure(new Rectangle(350, 150, 200, 100));
               ListOfFigures.AddFigure(new Square(650, 125, 150));
               ListOfFigures.AddFigure(new Triangle(100, 490, 250, 490, 175, 340));
               ListOfFigures.AddFigure(new Ellipse(350, 375, 200, 100));
               ListOfFigures.AddFigure(new Circle(650, 350, 150));

               foreach (Figure figure in ListOfFigures.list)
               {
                    figure.Draw();
               }

               pbSketchingArea.Image = bitmap;

          }

     }
}

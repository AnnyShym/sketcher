using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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
               bitmap = new Bitmap(Properties.Resources.drawing_pad_1209781_12802, pbSketchingArea.Width, pbSketchingArea.Height);
               graphics = Graphics.FromImage(bitmap);
               pen = new Pen(Color.DarkRed, 2);
          }

          private void ShowFigures()
          {

               ListOfFigures.AddFigure(new Line(100, 200, 250, 200));
               ListOfFigures.AddFigure(new Rectangle(350, 150, 200, 100));
               ListOfFigures.AddFigure(new Square(650, 125, 150));
               ListOfFigures.AddFigure(new Triangle(100, 490, 250, 490, 175, 340));
               ListOfFigures.AddFigure(new Ellipse(350, 375, 200, 100));
               ListOfFigures.AddFigure(new Circle(650, 350, 150));

               foreach (Figure figure in ListOfFigures.Expand())
               {
                    figure.Draw();
               }

               pbSketchingArea.Image = bitmap;

          }

          private void quitToolStripMenuItem_Click(object sender, EventArgs e)
          {
               Application.Exit();
          }

          private void newToolStripMenuItem_Click(object sender, EventArgs e)
          {
               bitmap = new Bitmap(pbSketchingArea.Width, pbSketchingArea.Height);
               pbSketchingArea.Image = bitmap;
          }

          private void openToolStripMenuItem_Click(object sender, EventArgs e)
          {

               openFileDialog.Title = "Open Background";
               openFileDialog.Filter = "bmp files (*.bmp)|*.bmp|jpg files (*.jpg)|*.jpg|jpeg files (*.jpeg)|*.jpeg|png files (*.png)|*.png|gif files (*.gif)|*.gif";
               openFileDialog.FilterIndex = 1;

               if (openFileDialog.ShowDialog() == DialogResult.OK)
               {
                    bitmap = new Bitmap(openFileDialog.FileName);
                    pbSketchingArea.Image = bitmap;
               }
               
               openFileDialog.Dispose();

          }

          private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
          {

               saveFileDialog.Title = "Save Picture";
               saveFileDialog.Filter = "bmp files (*.bmp)|*.bmp|jpg files (*.jpg)|*.jpg|jpeg files (*.jpeg)|*.jpeg|png files (*.png)|*.png|gif files (*.gif)|*.gif";
               saveFileDialog.FilterIndex = 1;

               if (saveFileDialog.ShowDialog() == DialogResult.OK)
               {

                    switch(saveFileDialog.FilterIndex)
                    {

                         case 1:
                              bitmap.Save(saveFileDialog.FileName, ImageFormat.Bmp);
                              break;

                         case 2:
                              bitmap.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
                              break;

                         case 3:
                              bitmap.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
                              break;

                         case 4:
                              bitmap.Save(saveFileDialog.FileName, ImageFormat.Png);
                              break;

                         case 5:
                              bitmap.Save(saveFileDialog.FileName, ImageFormat.Gif);
                              break;

                    }

               }

               saveFileDialog.Dispose();

          }

     }
}

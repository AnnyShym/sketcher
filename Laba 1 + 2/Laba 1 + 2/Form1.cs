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
               pbSketchingArea.Image = bitmap;
          }

     }
}

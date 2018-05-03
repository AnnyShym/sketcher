using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Laba_1___2
{
    public partial class fMain : Form
    {

        private static Bitmap bitmap;
        private static Graphics graphics;
        private static Pen pen;

        private bool mouseIsDown = false;
        private int x1, y1, x2, y2, width, height;

        private Figure newFigure;
        private int figureType = 0;

        private string fileName = "../../Resources/drawing-pad-1209781_12802.jpg";

        public fMain()
        {

            InitializeComponent();
            InitializeDrawingArea();

            ShowFigures();

        }

        private void InitializeDrawingArea()
        {

            if (fileName.Length != 0)
            {
                Image background = Image.FromFile(fileName);
                bitmap = new Bitmap(background, pbSketchingArea.Width, pbSketchingArea.Height);
            }
            else
                bitmap = new Bitmap(pbSketchingArea.Width, pbSketchingArea.Height);

            graphics = Graphics.FromImage(bitmap);
            pbSketchingArea.Image = bitmap;

            pen = new Pen(Color.DarkRed, 2);

        }

        private void InitializeWorkingArea()
        {
            ListOfFigures.Clear();
            newFigure = null;
            figureType = 0;
        }

        private void ShowFigures()
        {

            ListOfFigures.AddFigures(new Line(100, 200, 250, 200), new Rectangle(350, 150, 200, 100),
                                     new Square(650, 125, 150), new Rhombus(175, 340, 240, 425),
                                     new Ellipse(350, 375, 200, 100), new Circle(650, 350, 150));

            ListOfFigures.DrawFigures(graphics, pen);

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileName = "";
            InitializeDrawingArea();
            InitializeWorkingArea();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            openFileDialog.Title = "Open Background";
            openFileDialog.Filter = "bmp files (*.bmp)|*.bmp|jpg files (*.jpg)|*.jpg|jpeg files (*.jpeg)|*.jpeg|png files (*.png)|*.png|gif files (*.gif)|*.gif";
            openFileDialog.FilterIndex = 1;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;
                InitializeDrawingArea();
                InitializeWorkingArea();
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

                switch (saveFileDialog.FilterIndex)
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

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbSketchingArea_MouseDown(object sender, MouseEventArgs e)
        {

            mouseIsDown = true;

            x1 = e.X;
            y1 = e.Y;

        }

        private void pbSketchingArea_MouseMove(object sender, MouseEventArgs e)
        {

            if (mouseIsDown)
            {

                x2 = e.X;
                y2 = e.Y;

                pbSketchingArea.Invalidate();

            }

        }

        private void pbSketchingArea_MouseUp(object sender, MouseEventArgs e)
        {

            mouseIsDown = false;

            x1 = y1 = x2 = y2 = -1;

            if (newFigure != null)       
            {
                ListOfFigures.AddFigures(newFigure);
            }

        }

        private void freeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            figureType = 1;
        }

        private void lineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            figureType = 2;
        }

        private void ellipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            figureType = 3;
        }

        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            figureType = 4;
        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            figureType = 5;
        }

        private void squareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            figureType = 6;
        }

        private void rhombusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            figureType = 7;
        }

        private void pbSketchingArea_Paint(object sender, PaintEventArgs e)
        {

            if (x1 >= 0 && y1 >= 0 && x2 >= 0 && y2 >= 0)
            {

                width = Math.Abs(x1 - x2);
                height = Math.Abs(y1 - y2);

                switch (figureType)
                {

                    case 0:
                        return;

                    case 2:
                        newFigure = new Line(x1, y1, x2, y2);
                        break;

                    case 3:
                        newFigure = new Ellipse(x1, y1, width, height);
                        break;

                    case 4:
                        newFigure = new Circle(x1, y1, (width <= height) ? width : height);
                        break;

                    case 5:
                        newFigure = new Rectangle(x1, y1, width, height);
                        break;

                    case 6:
                        newFigure = new Square(x1, y1, (width <= height) ? width : height);
                        break;

                    case 7:
                        newFigure = new Rhombus(x1, y1, x2, y2);
                        break;

                }

                InitializeDrawingArea();

                newFigure.Draw(graphics, pen);
                ListOfFigures.DrawFigures(graphics, pen);

            }

        }

    }
}

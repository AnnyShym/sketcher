using System.Collections.Generic;
using System.Drawing;

namespace Laba_1___2
{
    public static class ListOfFigures
    {

        private static List<Figure> list;

        public static int FiguresCount
        {
            get { return list.Count; }
        }

        static ListOfFigures()
        {
            list = new List<Figure>();
        }

        public static void AddFigures(params Figure[] figures)
        {

            foreach (Figure figure in figures)
            {
                list.Add(figure);
            }

        }

        public static void DrawFigures(Graphics graphics, Pen pen)
        {

            foreach (Figure figure in list)
            {
                figure.Draw(graphics, pen);
            }

        }

        public static void Clear()
        {
            list.Clear();
        }

    }
}

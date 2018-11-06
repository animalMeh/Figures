using System;
using System.Drawing;
using System.Globalization;
using Figures.Properties;

namespace Figures.Model
{
    class Triangle : Figure 
    {
        static string FigureName = Resources.TriangleFigureName;
        const int DEFAULT_SIDE_LENGTH = 50;
        readonly int SideLength;
        static int Counter;
        Point[] TriangleSidesCoordinates;
      
        public Triangle(Point MaxCoordinate, int sideLength  = DEFAULT_SIDE_LENGTH, Pen pen = null) 
            :base(new Point(MaxCoordinate.X - sideLength , MaxCoordinate.Y - sideLength), pen)
        {
            Counter++;
            SideLength = sideLength;
            Width = sideLength;
            Height = (int)(Math.Sqrt(3) / 2 * sideLength);
            Name = Counter.ToString();
            TriangleSidesCoordinates = new Point[] { new Point(X, Y + Height), new Point(X + Width / 2, Y), new Point(X + Width, Y + Height), new Point(X, Y + Height) };
        }

        private void UpdateTriangleSidesCoordinates()
        {
            TriangleSidesCoordinates[0] = TriangleSidesCoordinates[3] = new Point(X, Y + Height);
            TriangleSidesCoordinates[1] = new Point(X + Width / 2, Y);
            TriangleSidesCoordinates[2] = new Point(X + Width, Y + Height);
        }

        public override void Draw(Graphics graphics)
        {
            Graphics g = graphics;
            UpdateTriangleSidesCoordinates();
            g.DrawLines(FigureColor ,TriangleSidesCoordinates);
        }

        public override void ChangeCulture(CultureInfo c)
        {
            base.ChangeCulture(c);
            FigureName = Resources.TriangleFigureName;
        }

        public override string ToString()
        {
            return string.Format($"{FigureName} #{Name}({base.ToString()})");
        }

        protected override void FigureClashed(ClashEventArgs e)
        {
            if (!(e.Second is Triangle))
            {
                base.FigureClashed(e);
            }
        }
    }
}

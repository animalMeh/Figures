using Figures.Properties;
using System;
using System.Drawing;
using System.Globalization;

namespace Figures.Model
{
    public class Triangle : Figure 
    {
        static string FigureName = Resources.TriangleFigureName;
        const int DEFAULT_SIDE_LENGTH = 50;
        readonly int SideLength;
        static int Counter;
        readonly Point[] triangleSidesCoordinates;
      
        public Triangle(Point MaxCoordinate, int sideLength  = DEFAULT_SIDE_LENGTH, Pen pen = null) 
            :base(new Point(MaxCoordinate.X - sideLength , MaxCoordinate.Y - sideLength), pen)
        {
            Counter++;
            SideLength = sideLength;
            Width = sideLength;
            Height = (int)(Math.Sqrt(3) / 2 * sideLength);
            Name = Counter.ToString();
            triangleSidesCoordinates = new Point[] { new Point(X, Y + Height), new Point(X + Width / 2, Y), new Point(X + Width, Y + Height), new Point(X, Y + Height) };
        }

        public override void Draw(Graphics graphics)
        {
            Graphics g = graphics;
            UpdateTriangleSidesCoordinates();
            g.DrawLines(FigureColor ,triangleSidesCoordinates);
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

        private void UpdateTriangleSidesCoordinates()
        {
            triangleSidesCoordinates[0] = triangleSidesCoordinates[3] = new Point(X, Y + Height);
            triangleSidesCoordinates[1] = new Point(X + Width / 2, Y);
            triangleSidesCoordinates[2] = new Point(X + Width, Y + Height);
        }
    }
}

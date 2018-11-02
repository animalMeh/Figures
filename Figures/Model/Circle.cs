using System;
using System.Drawing;
using System.Globalization;
using System.Resources;

namespace Figures.Model
{
    class Circle : Figure
    {
        public static string FIGURE_NAME = "Circle";
        const int DEFAULT_RADIUS = 25;
        static int Counter;
        readonly int Radius;
        

        public Circle(Point MaxCoordinate, int Radius = DEFAULT_RADIUS, Pen pen = null)
            :base( new Point(MaxCoordinate.X-Radius*2 , MaxCoordinate.Y-Radius*2), pen)
        {
            Counter++;
            this.Radius = Radius;
            Width = Radius * 2;
            Height = Radius * 2;
            Name = Counter.ToString();
        }

        public override void Draw(Graphics graphics)
        {
            Graphics g = graphics;
            g.DrawEllipse(FigureColor, X, Y, Width, Height);
        }

       
        public override string ToString()
        {               
            return string.Format($"{FIGURE_NAME} #{Name}: {base.ToString()}");
        }

    }
}

using System;
using System.Drawing;
using System.Globalization;
using Figures.Properties;

namespace Figures.Model
{
    class Circle : Figure
    {
        public static string FIGURE_NAME = Resources.CircleFigureName;
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

        public override void ChangeCulture(CultureInfo c)
        {
            base.ChangeCulture(c);
            //if(c.Name == "en")
            //{
            //    FIGURE_NAME = "Circle";
            //}
            //if(c.Name == "ru")
            //{
            //    FIGURE_NAME = "Круг";
            //}
        }

        public override string ToString()
        {               
            return string.Format($"{FIGURE_NAME} #{Name}: {base.ToString()}");
        }

    }
}

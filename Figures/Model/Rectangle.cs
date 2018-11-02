using System;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using Figures.Properties;

namespace Figures.Model
{
    class Rectangle : Figure
    {
        static string FIGURE_NAME = Resources.RectangleFigureName;
        const int DEFAULT_WIDTH = 50;
        const int DEFAULT_HEIGHT = 50;

        static int Counter;

        public Rectangle(Point MaxCoordinate , int Width  = DEFAULT_WIDTH, int Height = DEFAULT_HEIGHT , Pen pen = null )
            :base(new Point(MaxCoordinate.X -Width , MaxCoordinate.Y - Height) , pen)
        {
            Counter++;
            this.Width = Width;            
            this.Height = Height;
            Name = Counter.ToString();

        }

        public override void Draw(Graphics graphics)
        {
            Graphics g = graphics;
            g.DrawRectangle(FigureColor, X, Y, Width, Height);
        }

        public override void ChangeCulture(CultureInfo c)
        {
            base.ChangeCulture(c);
            FIGURE_NAME = "Прямоугольник";
        }

        public override string ToString()
        {
            return string.Format($"{FIGURE_NAME} #{Name}: {base.ToString()}");
        }

    }
}

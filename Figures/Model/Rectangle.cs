using System;
using System.Drawing;
using System.Reflection;

namespace Figures.Model
{
    class Rectangle : Figure
    {
        const string FIGURE_NAME = "Rectangle";
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

        public override string ToString()
        {
            return string.Format($"{FIGURE_NAME} #{Name}: {base.ToString()}");
        }

    }
}

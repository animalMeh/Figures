using System;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using Figures.Properties;

namespace Figures.Model
{
    class Rectangle : Figure
    {
        static string FigureName = Resources.RectangleFigureName;
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
            FigureName = Resources.RectangleFigureName;
        }

        public override string ToString()
        {
            return string.Format($"{FigureName} #{Name}({base.ToString()})");
        }

        protected override void FigureClashed(ClashEventArgs e)
        {
            if(!(e.Second is Rectangle))
            {
                base.FigureClashed(e);
            }
        }

    }
}

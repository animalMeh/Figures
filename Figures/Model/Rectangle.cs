using System;
using Figures.Properties;
using System.Drawing;
using System.Xml.Serialization;
using System.Globalization;
using System.Runtime.Serialization;

namespace Figures.Model
{
    [Serializable,XmlInclude(typeof(Figure))]
    public class Rectangle : Figure
    {
        static int Counter;
        static string FigureName = Resources.RectangleFigureName;
        const int DEFAULT_WIDTH = 50;
        const int DEFAULT_HEIGHT = 50;   
        
        public Rectangle():base() { }

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

        protected override void Clash(ClashEventArgs e)
        {
            if(!(e.Second is Rectangle))
            {
                base.Clash(e);
            }
        }
    }
}

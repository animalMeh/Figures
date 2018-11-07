using System;
using System.Drawing;
using System.Globalization;
using Figures.Properties;
using System.Xml.Serialization;

namespace Figures.Model
{
    [Serializable, XmlInclude(typeof(Figure))]
    public class Circle : Figure
    {
        public static string FigureName = Resources.CircleFigureName;
        const int DEFAULT_RADIUS = 25;
        static int Counter;
        readonly int Radius;
        
        public Circle():base() { }

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
           // Console.WriteLine("Поток в котором отрисовывается"); Показать что работает корректно
        }

        public override void ChangeCulture(CultureInfo c)
        {
            base.ChangeCulture(c);
            FigureName = Resources.CircleFigureName;
        }

        public override string ToString()
        {               
            return string.Format($"{FigureName} #{Name} ({base.ToString()})");
        }

        protected override void Clash(ClashEventArgs e)
        {
            if (!(e.Second is Circle))
            {
                base.Clash(e);
            }
        }
    }
}

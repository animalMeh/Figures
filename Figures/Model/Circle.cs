using System;
using System.Drawing;

namespace Figures.Model
{
    class Circle : Figure
    {
        static int Counter;
        readonly int Radius;
        

        public Circle(int x , int y , int Radius , Pen pen)
            :base(x , y, pen)
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
            g.DrawEllipse(Pen, X, Y, Width, Height);
        }

        public override string ToString()
        {
            return string.Format($"Circle #{Name}");
        }

    }
}

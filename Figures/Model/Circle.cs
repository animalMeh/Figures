using System;
using System.Drawing;

namespace Figures.Model
{
    class Circle : Figure
    {

        readonly int Radius;

        public Circle(int x , int y , int Radius , Pen pen)
            :base(x , y, pen)
        {
            this.Radius = Radius;
            Width = Radius * 2;
            Height = Radius * 2;
        }

        public override void Draw(Graphics graphics)
        {
            Graphics g = graphics;
            g.DrawEllipse(Pen, X, Y, Width, Height);
        }

    }
}

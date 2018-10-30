using System;
using System.Drawing;

namespace Figures.Model
{
    class Triangle : Figure // equilateral
    {
        readonly int SideLength;

        public Triangle(int x , int y , int sideLength , Pen pen) 
            :base(x , y , pen)
        {
            SideLength = sideLength;
            Width = sideLength;
            Height = ((int)(Math.Sqrt(3) / 2 * sideLength));
        }

        public override void Draw(Graphics graphics)
        {
            Graphics g = graphics;
            g.DrawLines(Pen ,new Point[] { new Point(X , Y+Height) , new Point(X +Width/2 , Y) , new Point(X+Width , Y+ Height), new Point(X, Y + Height) });
        }

    }
}

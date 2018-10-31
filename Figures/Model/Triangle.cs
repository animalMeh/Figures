using System;
using System.Drawing;

namespace Figures.Model
{
    class Triangle : Figure 
    {
        readonly int SideLength;
        static int Counter;
      
        public Triangle(int x , int y , int sideLength , Pen pen) 
            :base(x , y , pen)
        {

            Counter++;
            SideLength = sideLength;
            Width = sideLength;
            Height = ((int)(Math.Sqrt(3) / 2 * sideLength));
            Name = Counter.ToString();
        }

        public override void Draw(Graphics graphics)
        {
            Graphics g = graphics;
            g.DrawLines(Pen ,new Point[] { new Point(X , Y+Height) , new Point(X +Width/2 , Y) , new Point(X+Width , Y+ Height), new Point(X, Y + Height) });
        }

        public override string ToString()
        {
            return string.Format($"Triangle #{Name}");
        }
     
    }
}

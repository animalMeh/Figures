using System;
using System.Drawing;
using System.Reflection;
using Figures.Controller;
namespace Figures.Model
{
    class Rectangle : Figure
    {
          
        readonly int Width;
        readonly int Height;

        public Rectangle(int x , int y ,int Width , int Height , Pen pen )
            :base(x,y, pen)
        {
            this.Width = Width;
            
            this.Height = Height;
        }

        public override void Draw(Graphics graphics)
        {
            Graphics g = graphics;
            g.DrawRectangle(Pen, X, Y, Width, Height);
        }

        public override void Move(Point pMin , Point pMax)
        {          
           
            if (Y <= pMin.Y)
                dY = -dY;
            if (Y + Height >= pMax.Y)
                dY = -dY;
            if (X + Width >= pMax.X)
                dX = -dX;
            if (X <= pMin.X)
                dX = -dX;
            DirectMove();
           
        }
    }
}

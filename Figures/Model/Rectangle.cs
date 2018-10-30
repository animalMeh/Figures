using System;
using System.Drawing;
using System.Reflection;
using Figures.Controller;
namespace Figures.Model
{
    class Rectangle : Figure
    {
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

    }
}

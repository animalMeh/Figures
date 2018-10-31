using System;
using System.Drawing;
using System.Reflection;
using Figures.Controller;
namespace Figures.Model
{
    class Rectangle : Figure
    {
        static int Counter;

        public Rectangle(int x , int y ,int Width , int Height , Pen pen )
            :base(x,y, pen)
        {
            Counter++;
            this.Width = Width;            
            this.Height = Height;
            Name = Counter.ToString();

        }

        public override void Draw(Graphics graphics)
        {
            Graphics g = graphics;
            g.DrawRectangle(Pen, X, Y, Width, Height);
        }

        public override string ToString()
        {
            return string.Format($"Rectangle #{Name}");
        }

    }
}

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
        }

        public override void Draw(Graphics graphics)
        {
            throw new NotImplementedException();
        }

        public override void Move(Point pMin, Point pMax)
        {
            throw new NotImplementedException();
        }
    }
}

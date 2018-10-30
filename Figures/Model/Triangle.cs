using System;
using System.Drawing;

namespace Figures.Model
{
    class Triangle : Figure // equilateral
    {
        //x , y , по умолчанию равносторонний
        readonly int SideLength;

        public Triangle(int x , int y , int sideLength , Pen pen) // проверка на корректность ввода?
            :base(x , y , pen)
        {
            SideLength = sideLength;
        }

        public override void Draw(Graphics graphics)
        {
            throw new NotImplementedException();
        }

        public override void Move(Point pMin , Point pMax)
        {
            throw new NotImplementedException();
        }
    }
}

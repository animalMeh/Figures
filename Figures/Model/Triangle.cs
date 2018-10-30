using System;
using System.Drawing;

namespace Figures.Model
{
    class Triangle : Figure // equilateral
    {
        int SideLength;
        //x , y , 3 cтороны, по умолчанию равносторонний

        public Triangle(int x , int y , int sideLength , Pen pen) // проверка на корректность ввода?
            :base(x , y , pen)
        {
            SideLength = sideLength;
        }

        public override void Draw()
        {
            throw new NotImplementedException();
        }

        public override void Move()
        {
            throw new NotImplementedException();
        }
    }
}

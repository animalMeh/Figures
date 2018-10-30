using System.Drawing;

namespace Figures.Model
{
    abstract class Figure
    {

        protected Figure(int x , int y, Pen p)
        {
            X = x;
            Y = y;
            Pen = p;
        }
        protected int X { get; set; }
        protected int Y { get; set; }
        protected Pen Pen { get; set; }

        abstract public void Move();
        abstract public void Draw();
    }
}

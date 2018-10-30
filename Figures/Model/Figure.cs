using System.Drawing;


namespace Figures.Model
{
    abstract class Figure
    {
        const int Increment = 2;
        protected int dX = Increment;
        protected int dY = Increment;

        protected Figure(int x , int y, Pen p)
        {
            X = x;
            Y = y;
            Pen = p;
        }
        protected int X { get; set; }
        protected int Y { get; set; }
       
        protected Pen Pen { get; set; }

        abstract public void Move(Point pMin , Point pMax);// height of our form
        abstract public void Draw(Graphics graphics);


    }
}

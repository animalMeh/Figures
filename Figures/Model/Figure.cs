using System;
using System.Drawing;
using Figures.Controller;

namespace Figures.Model
{
    abstract class Figure
    {
        const int Increment = 3;
        protected int dX = Increment;
        protected int dY = Increment;
        readonly Direction Direction;

        protected Figure(int x , int y, Pen p)
        {
            Direction = (Controller.Direction)((Random)Activator.CreateInstance(typeof(Random))).Next(0, 4);
            X = x;
            Y = y;
            Pen = p;
        }
        public int X { get;protected set; }
        public int Y { get;protected set; }
       
        protected Pen Pen { get; set; }

        abstract public void Move(Point pMin , Point pMax);// height of our form
        abstract public void Draw(Graphics graphics);

        protected void DirectMove()
        {
            if (Direction == Direction.Initial315)
            {
                X += dX;
                Y += dY;
            }
            if (Direction == Direction.Initial45)
            {
                X -= dX;
                Y -= dY;
            }
            if (Direction == Direction.Initial225)
            {
                X += dX;
                Y -= dY;
            }
            if (Direction == Direction.Initial135)
            {
                X -= dX;
                Y += dY;
            }
        }

    }
}

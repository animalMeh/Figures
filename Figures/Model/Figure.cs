using System;
using System.Drawing;
using Figures.Controller;

namespace Figures.Model
{
    abstract class Figure 
    {
        private bool IsStopped = false;
        public string Name { get;protected set; }
        const int Increment = 3;
        protected int dX = Increment;
        protected int dY = Increment;
        readonly Direction Direction;
        public int X { get;protected set; }
        public int Y { get;protected set; }      
        protected Pen Pen { get; set; }
        protected int Height { get; set; }
        protected int Width { get; set; }

        protected Figure(int x , int y, Pen p)
        {
            Direction = (Controller.Direction)((Random)Activator.CreateInstance(typeof(Random))).Next(0, 4);
            X = x;
            Y = y;
            Pen = p;
        }
        abstract public void Draw(Graphics graphics);

        public void Move(Point pMin, Point pMax)
        {
            if (!IsStopped)
            {
                if (Y <= pMin.Y)
                    dY = -dY;
                if (Y + Height >= pMax.Y)
                    dY = -dY;
                if (X + Width >= pMax.X)
                    dX = -dX;
                if (X <= pMin.X)
                    dX = -dX;

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

        public void Stop()
        {
            IsStopped = true;
        }

    }
}

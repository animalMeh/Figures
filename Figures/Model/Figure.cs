using System;
using System.Globalization;
using System.Drawing;


namespace Figures.Model
{
    abstract class Figure :IDisposable
    {
        readonly Random Randomizer = new Random();
        string STATE_ACTIVE = "Active";
        string STATE_STOPPED = "Stopped";
        private int dX;
        private int dY;
        public int X { get;protected set; }
        public int Y { get;protected set; }      
        
        protected Pen FigureColor = new Pen(Color.Black); 
        protected int Height { get; set; }
        protected int Width { get; set; }

        public string Name { get;protected set; }
        public bool IsStopped { get; set; }

        protected Figure(Point MaxCoordinate, Pen p = null)
        {
            while (dX == 0 || dY == 0)
            {
                dX = Randomizer.Next(-4, 4);
                dY = Randomizer.Next(-4, 4);
            }
            X = Randomizer.Next(0, MaxCoordinate.X);
            Y = Randomizer.Next(0, MaxCoordinate.Y);
            if (!(p is null))
                FigureColor = p;
            
        }
      
        abstract public void Draw(Graphics graphics);

        public void Move(Point pMax)
        {
            if (!IsStopped)
            {
                if (Y <= 0)
                    dY = -dY;
                if (Y + Height >= pMax.Y)
                    dY = -dY;
                if (X + Width >= pMax.X)
                    dX = -dX;
                if (X <= 0)
                    dX = -dX;
                X += dX;
                Y += dY;        
            }
        }

        public void Dispose()
        {
            FigureColor.Dispose();
        }

        public virtual void ChangeCulture(CultureInfo c)
        {
            if(c.Name == "en")
            {
                STATE_ACTIVE = "Active";
                STATE_STOPPED = "Stopped";
            }
            if(c.Name == "ru")
            {
                STATE_ACTIVE = "Активно";
                STATE_STOPPED = "Остановлено";
            }
        }

        public override string ToString()
        {
            
            if (IsStopped)
                return STATE_STOPPED;
            else return STATE_ACTIVE;
        }
    }
}

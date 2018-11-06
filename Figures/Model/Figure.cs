using System;
using System.Globalization;
using System.Drawing;
using Figures.Properties;

namespace Figures.Model
{
    abstract class Figure :IDisposable , IIntersectable
    {     
        string StateActive = Resources.STATE_ACTIVE;     
        string StateStopped = Resources.STATE_STOPPED;

        private int dX;
        private int dY;

        public int X { get;protected set; }
        public int Y { get;protected set; }      

        protected Pen FigureColor = new Pen(Randomizer.Randomizer.GetColor()); 

        public int Height { get;protected set; }
        public int Width { get; protected set; }

        public string Name { get;protected set; }
        public bool IsStopped { get; set; }

        protected Figure(Point MaxCoordinate, Pen p = null)
        {
            while (dX == 0 || dY == 0)
            {
                dX = Randomizer.Randomizer.GetValue(-4, 4);
                dY = Randomizer.Randomizer.GetValue(-4, 4);
            }
            X = Randomizer.Randomizer.GetValue(0, MaxCoordinate.X);
            Y = Randomizer.Randomizer.GetValue(0, MaxCoordinate.Y);
            if (!(p is null))
                FigureColor = p;
            
        }

        public event EventHandler<ClashEventArgs> FiguresClashed;

        abstract public void Draw(Graphics graphics);

        protected virtual void FigureClashed(ClashEventArgs e)
        {
            EventHandler<ClashEventArgs> temp = FiguresClashed;
            temp?.Invoke(this, e);
        }

        public void SimulateFigureClashed(Figure To)
        {
            ClashEventArgs cea = new ClashEventArgs(this, To);
            FigureClashed(cea);
        }

        public void Move(Point pMax , IIntersectable[] otherFigures)
        {          
            if(otherFigures.Length > 1)
            {
                ////
                for (int i = 0; i < otherFigures.Length; i++)
                    if (IsIntersect(otherFigures[i])&& this != otherFigures[i])
                    {
                        ChangeDirection();
                        SimulateFigureClashed((Figure)otherFigures[i]);
                    }
                ////
            }

            if (!IsStopped)
            {
                if (Y <= 0 || Y + Height >= pMax.Y)
                    dY = -dY;
                if (X + Width >= pMax.X || X <= 0)
                    dX = -dX;
                X += dX;
                Y += dY;        
            }
        }
        
        public virtual void ChangeCulture(CultureInfo c)
        {
            if(c.Name == "en")
            {
              StateActive = Resources.STATE_ACTIVE;
              StateStopped = Resources.STATE_STOPPED;
            }
            if(c.Name == "ru")
            {
               StateActive = Resources.STATE_ACTIVE;
               StateStopped = Resources.STATE_STOPPED;
            }
        }

        public override string ToString()
        {
            
            if (IsStopped)
                return StateStopped;
            else return StateActive;
        }

        public bool IsIntersect(IIntersectable obj)
        {
            if (X + Width >= obj.X && X <= obj.X + obj.Width && Y + Height >= obj.Y && Y <= obj.Y + obj.Height)
                return true;
            else return false;
        }

         void ChangeDirection()
        {
            dX = -dX;
            dY = -dY;
            X += dX;
            Y += dY;
        }

        public void Dispose()
        {
            FigureColor.Dispose();
        }

    }
}

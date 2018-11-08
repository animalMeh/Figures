using Figures.Properties;
using System;
using System.Globalization;
using System.Drawing;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Figures.Model
{
    [DataContract, KnownType(typeof(Circle)), KnownType(typeof(Rectangle)), KnownType(typeof(Triangle))]
    [Serializable, XmlInclude(typeof(Triangle)) , XmlInclude(typeof(Circle)) , XmlInclude(typeof(Rectangle))]
    public abstract class Figure :IDisposable, IIntersectable
    {
        [XmlIgnore][DataMember]
        public string StateActive = Resources.STATE_ACTIVE;
        [XmlIgnore][DataMember]
        public string StateStopped = Resources.STATE_STOPPED;

        [DataMember]
        public int dX;
        [DataMember]
        public int dY;

        [DataMember]
        public int X { get;set; }
        [DataMember]
        public int Y { get;set; }

        [DataMember]
        public Color PenColor { get; set; } = Randomizer.Randomizer.GetColor();
        [NonSerialized]
        protected Pen FigureColor = new Pen(Randomizer.Randomizer.GetColor());

        [DataMember]
        public int Height { get;set; }
        [DataMember]
        public int Width { get;set; }

        [DataMember]
        public string Name { get;set; }
        [DataMember]
        public bool IsStopped { get; set; }

        public event EventHandler<ClashEventArgs> FigureClash;

        abstract public void Draw(Graphics graphics);

        public Figure(){ }

        protected Figure(Point MaxCoordinate, Color? p = null)
        {         
            while (dX == 0 || dY == 0)
            {
                dX = Randomizer.Randomizer.GetValue(-4, 4);
                dY = Randomizer.Randomizer.GetValue(-4, 4);
            }
            X = Randomizer.Randomizer.GetValue(0, MaxCoordinate.X);
            Y = Randomizer.Randomizer.GetValue(0, MaxCoordinate.Y);

            if (!(p is null))
            {
                PenColor = (Color)p; 
            }
            FigureColor = new Pen(PenColor);       
        }

        public void Move(Point pMax , IIntersectable[] otherFigures)
        {
            if (!IsStopped)
                PreventCrossingTheBorder(pMax);
            MoveInClashing(otherFigures);
        }

        public bool IsIntersect(IIntersectable obj)
        {
            return X + Width >= obj.X && X <= obj.X + obj.Width && Y + Height >= obj.Y && Y <= obj.Y + obj.Height;
        }

        public void SimulateFigureClashed(Figure To)
        {
            ClashEventArgs cea = new ClashEventArgs(this, To);
            Clash(cea);
        }
        
        public virtual void ChangeCulture(CultureInfo c)
        {
            if(c.Name == "en")
            {
              StateActive = Resources.STATE_ACTIVE;
              StateStopped = Resources.STATE_STOPPED;
            }

            if (c.Name == "ru")
            {
               StateActive = Resources.STATE_ACTIVE;
               StateStopped = Resources.STATE_STOPPED;
            }
        }

        public override string ToString()
        {
            if (IsStopped)
            {
                return StateStopped;
            }
            else
            {
                return StateActive;
            }
        }

        protected virtual void Clash(ClashEventArgs e)
        {
            EventHandler<ClashEventArgs> temp = FigureClash;
            temp?.Invoke(this, e);
        }

        private void PreventCrossingTheBorder(Point pMax)
        {
            if (Y <= 0 || Y + Height >= pMax.Y)
                dY = -dY;
            if (X + Width >= pMax.X || X <= 0)
                dX = -dX;
            X += dX;
            Y += dY;
        }

        private void MoveInClashing(IIntersectable[] otherFigures)
        {
            if(otherFigures.Length > 1)
            {
                foreach (var f in otherFigures)
                {
                    if (IsIntersect(f) && this != f)
                    {
                       ChangeDirection();
                       if (IsIntersect(f))
                            ChangeDirection();
                       else
                            SimulateFigureClashed((Figure)f);
                    }
                }
            }
        }

        private void ChangeDirection()
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

        [OnDeserialized]
        internal void SwitchPen(StreamingContext context)
        {
            FigureColor = new Pen(PenColor);
        }
    }
}

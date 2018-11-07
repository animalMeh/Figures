using System;
using System.Drawing;
using Figures.Model;
using System.Threading;

namespace Figures
{
     class MovingHelper
    {
        public Figure HostFigure { get; set; }
        public Point Coordinate { get; set; }
        public Figure[] Figures { get; set; }
        public void Move()
        {
            HostFigure?.Move(Coordinate, Figures);
           // Console.WriteLine("Поток в котором двигается " + Thread.CurrentThread.Name); //show this
        }
        public static void AsyncMove(Figure hostFigure, Point coordinates, Figure [] figures)
        {
            MovingHelper mH = new MovingHelper { Figures = figures, Coordinate = coordinates , HostFigure = hostFigure };
            Thread t = new Thread(mH.Move);
            t.Start();
        }
    }
}

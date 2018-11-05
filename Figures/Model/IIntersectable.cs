using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures.Model
{
    interface IIntersectable
    {
        int X { get; }
        int Y { get; }

        int Height { get; }
        int Width { get; }

        bool IsIntersect(IIntersectable obj);
    }
}

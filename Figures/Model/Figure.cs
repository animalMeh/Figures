using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures.Model
{
    abstract class Figure
    {
        protected int X { get; set; }
        protected int Y { get; set; }

        abstract public void Move();
        abstract public void Draw();
    }
}

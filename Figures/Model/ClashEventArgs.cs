using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures.Model
{
    class ClashEventArgs :EventArgs
    {
        public ClashEventArgs(Figure from , Figure to)
        {
            First = from;
            Second = to;
        }
        public Figure First { get; private set; }
        public Figure Second { get; private set; }
    }
}

using System;

namespace Figures.Model
{
    public class ClashEventArgs :EventArgs
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

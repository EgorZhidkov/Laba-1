using System;
using System.Collections.Generic;
using System.Text;


namespace lab2
{
    public abstract class GeometrickFigure : IComparable
    {
        protected string Type;
        public string Type1
        {
            get;
            set;
        }
        public abstract double Square();
        public int CompareTo(object obj)
        {
            GeometrickFigure p = (GeometrickFigure)obj;
            if (this.Square() < p.Square()) return -1;
            else if (this.Square() == p.Square()) return 0;
            else return 1;
        }
    }
}

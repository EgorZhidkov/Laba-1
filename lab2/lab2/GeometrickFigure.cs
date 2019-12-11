using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    abstract class GeometrickFigure
    {
        protected string Type;
        public string Type1
        {
            get;
            set;
        }
        public virtual double Square
        {
            get;
        }
    }
}

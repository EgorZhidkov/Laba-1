using System;
using System.Collections.Generic;
using System.Text;
using lab2;

namespace lab3
{
    class GeometrickMatrixCheckEmpty : IMatrixCheckEmpty<GeometrickFigure>
    {
        public GeometrickFigure getEmptyElement()
        {
            return null;
        }
        public bool checkEmptyElement(GeometrickFigure element)
        {
            bool Result = false;
            if (element == null)
            {
                Result = true;
            }
            return Result;
        }
    }
}


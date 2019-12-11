using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    class Foursquare : Rectangle
    {
        public Foursquare(int length) : base(length, length)
        {
            this.length = length;
            this.Type1 = "Квадрат";
        }
        public override double Square
        {
            get
            {
                return length * length;
            }

        }
        public override string ToString()
        {
            return "Название фигуры: " + Type1.ToString() + " Длина стороноы " + length.ToString() + " Площадь: " + Square; ;
        }
    }
}

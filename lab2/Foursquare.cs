using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    public class Foursquare : Rectangle
    {
        public Foursquare(int length) : base(length, length)
        {
            this.Type = "Квадрат";
        }
        public override string ToString()
        {
            return "Название фигуры: " + Type.ToString() + " _ Длина стороны " + this.length1.ToString() + " _ Площадь: " + Square(); ;
        }
    }
}

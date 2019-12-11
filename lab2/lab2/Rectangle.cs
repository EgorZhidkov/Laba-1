using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    class Rectangle : GeometrickFigure, IPrint
    {
        public override double Square
        {
            get
            {
                return length * width;
            }

        }
        protected int length;
        protected int width;
        public int length1
        {
            get;
            set;
        }
        public int width1
        {
            get;
            set;
        }
        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
            this.Type1 = "Прямоугольник";
        }
        public override string ToString()
        {
            return "Название фигуры: " + Type1.ToString() + " Длина: " + length.ToString() + " Ширина: " + width.ToString() + " Площадь: " + Square;
        }
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }


    }
}

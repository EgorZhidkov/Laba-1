using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    public class Rectangle : GeometrickFigure, IPrint
    {
        public override double Square()
        {
                return length1 * width;
        }

        private int width;
        public int length1 { get; set; }
        public int width1
        {
            get;
            set;
        }
        public Rectangle(int length, int width)
        {
            this.length1 = length;
            this.width = width;
            this.Type = "Прямоугольник";
        }
        public override string ToString()
        {
            return "Название фигуры: " + Type.ToString() + " _ Длина: " + length1.ToString() + " _ Ширина: " + width.ToString() + " _ Площадь: " + Square();
        }
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }


    }
}

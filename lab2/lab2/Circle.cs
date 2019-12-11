using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    class Circle : GeometrickFigure, IPrint
    {
        protected int radius;
        public int radius1
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }
        public Circle(int radius)
        {
            this.radius = radius;
            this.Type1 = "Круг";
        }
        public override string ToString()
        {
            return "Название фигуры: " + Type1.ToString() + " Радиус: " + radius.ToString() + " Площадь: " + Square; ;
        }
        public override double Square
        {
            get
            {
                return (Math.PI * radius * radius);
            }
        }
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}

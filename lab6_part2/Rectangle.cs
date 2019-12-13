using System;
using System.Collections.Generic;
using System.Text;
using lab2;
namespace lab6_part2
{
    public class Rectangle : GeometrickFigure, IPrint
    {
        public override double Square()
        {
            return length * width;
        }
        private int length;
        public int width;
        
        [NewAttribute("Описание для property1")]
        public int length1
        {
            get
            {
                return length;
            }
            set
            {
                this.length = value;
            }
        }
        public int width1
        {
            get;
            set;
        }
        public Rectangle()
        {
             this.Type = "Прямоугольник";
        }
        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
            this.Type = "Прямоугольник";
        }
        public override string ToString()
        {
            return "Название фигуры: " + Type.ToString() + " _ Длина: " + length.ToString() + " _ Ширина: " + width.ToString() + " _ Площадь: " + Square();
        }
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
        public int Division(int i, int c)
        {
            return (i * c);
        }


    }
}

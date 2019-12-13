using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle b = new Rectangle(12,2);
            Foursquare a = new Foursquare(4);
            Circle c = new Circle(2);
            b.Print();
            a.Print();
            c.Print();
            b.length1 = 4;
            b.Print();
        }
    }
}

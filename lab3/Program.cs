using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab2;

namespace lab3
{
    class Program
    {
        static void Main()
       {
            Rectangle first = new Rectangle(9, 4);
            Foursquare second = new Foursquare(5);
            Circle third = new Circle(3);


            Console.WriteLine("\nArrayList");
            ArrayList first_array = new ArrayList();
            first_array.Add(first);
            first_array.Add(second);
            first_array.Add(third);
            foreach (var x in first_array)
                Console.WriteLine(x);

            List<GeometrickFigure> second_array = new List<GeometrickFigure>();
            second_array.Add(first);
            second_array.Add(second);
            second_array.Add(third);
            Console.WriteLine("\nList");
            foreach (var i in second_array)
                Console.WriteLine(i);

            second_array.Sort();
            Console.WriteLine("\nList sorted");

            foreach (var i in second_array)
                Console.WriteLine(i);

            Console.WriteLine("\nStack");
            SimpleStack<GeometrickFigure> stack = new SimpleStack<GeometrickFigure>();
            stack.Push(first);
            stack.Push(second);
            stack.Push(third);
            while (stack.Count > 0)
            {
                GeometrickFigure f = stack.Pop();
                Console.WriteLine(f);
            }

            Console.WriteLine("\nМатрица");
            Matrix<GeometrickFigure> matrix = new Matrix<GeometrickFigure>(3, 3, 3, new GeometrickMatrixCheckEmpty());
            matrix[0, 0, 0] = first;
            matrix[1, 1, 1] = second;
            matrix[2, 2, 2] = third;
            Console.WriteLine(matrix.ToString());

           
                


        }
    }
}

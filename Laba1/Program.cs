using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace laba1
{
    class Program
    {

        /*public static void CheckName(ref Double test)
        {
            bool count = true;
            int count_for_point = 0;
            string A = Console.ReadLine();
            while (count != false)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (Convert.ToInt32(A[i]) == 44)
                    {
                        count_for_point++;
                    }
                    if (((Convert.ToInt32(A[i]) < 48) || (Convert.ToInt32(A[i]) > 57)) && ((Convert.ToInt32(A[i]) != 44) || (count_for_point > 1) || (((Convert.ToInt32(A[0])) == 44) || (Convert.ToInt32(A[A.Length - 1]) == 44))))
                    {
                        if (Convert.ToInt32(A[0]) != 45)
                        {
                            count = false;
                        }
                    }
                }
                if (count == true)
                {
                    test = Convert.ToDouble(A);
                    // Console.WriteLine(test);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Коэффициент введен правильно");
                    Console.ResetColor();
                    count = false;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Не правильно, введите еще раз");
                    Console.ResetColor();
                    A = Console.ReadLine();
                    count = true;
                    count_for_point = 0;
                }
            }
        }*/
        public static void TryParseNameS(ref Double test)
        {
            string A = Console.ReadLine();
            bool count = false;
            while (count == false)
            {
                //success_convertation = Double.TryParse(A, out test);
                if (Double.TryParse(A, out test))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Коэффициент введен правильно");
                    Console.ResetColor();
                    count = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Не правильно, введите еще раз");
                    Console.ResetColor();
                    A = Console.ReadLine();

                }
            }
        }
        static void Main(string[] args)
        {

            Double a = 0, b = 0, c = 0, arg1 = 0, arg2 = 0, arg3 = 0;
            Double x1 = 0, x2 = 0, x3 = 0, x4 = 0;
            bool val1 = false, val2 = false, val3 = false;
            bool check = false;


            Console.Title = "Жидков Е.И. гр.ИУ5-33Б";
            if (args != null && args.Length == 3)
            {
                val1 = double.TryParse(args[0], out a);
                val2 = double.TryParse(args[1], out b);
                val3 = double.TryParse(args[2], out c);
            }
            if (val1 != true || val2 != true || val3 != true)
            {
                Console.Write("Введите коэффициент A:");
                TryParseNameS(ref a);
                Console.Write("Введите коэффициент B:");
                TryParseNameS(ref b);
                Console.Write("Введите коэффициент C:");
                TryParseNameS(ref c);
            }
            double D = (Math.Pow(b, 2) - (4 * a * c));
            double first_value_of_d = ((-b + Math.Sqrt(D)) / (2 * a));
            double second_value_of_d = ((-b - Math.Sqrt(D)) / (2 * a));
            double value = 0;
            if (a == 0)
            {
                if (b != 0)
                {
                    if (c == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.Write("X=0");
                        Console.ResetColor();

                    }
                    else
                    {
                        if (c / b < 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;

                            Console.Write($"x1 = {Math.Sqrt(-(c / b))}; x2 = {-(Math.Sqrt(-(c / b)))}");
                            Console.ResetColor();

                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;

                            Console.Write("Нет решений");
                            Console.ResetColor();

                        }
                    }
                }
                else
                {
                    if (c != 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.Write("Нет решений");
                        Console.ResetColor();


                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.Write("X любое");
                        Console.ResetColor();

                    }

                }
            }
            else
            {
                if (D < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.Write("Нет решений");
                    Console.ResetColor();

                }
                else
                {
                    if (first_value_of_d > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.Write($"x1 = {Math.Sqrt(first_value_of_d)}; x2 = {-(Math.Sqrt(first_value_of_d))}");
                        Console.ResetColor();

                        check = true;
                    }
                    if (second_value_of_d > 0)
                    {
                        if (check == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;

                            Console.WriteLine($" x3 = {Math.Sqrt(second_value_of_d)}; x4 = {-(Math.Sqrt(second_value_of_d))}");
                            Console.ResetColor();

                        }
                        if (check == false)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;

                            Console.WriteLine($"x1 = {Math.Sqrt(second_value_of_d)}; x2 = {-(Math.Sqrt(second_value_of_d))}");
                            Console.ResetColor();

                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}

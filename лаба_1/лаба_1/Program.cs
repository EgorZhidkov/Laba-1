using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace laba3._1
{
    class Program
    {
        public static double Discriminant(ref double a, ref double b, ref double c)
        {
            double D = Math.Sqrt(Math.Pow(b, 2) - (4 * a * c));
            //Console.WriteLine(D);
            return D;
        }
        public static void CheckName(ref Double test)
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
                    if (((Convert.ToInt32(A[i]) < 48) || (Convert.ToInt32(A[i]) > 57)) && ((Convert.ToInt32(A[i]) != 44) || (count_for_point > 1) || (Convert.ToInt32(A[0])) == 44) || (Convert.ToInt32(A[A.Length - 1]) == 44)
                        )
                    {
                        count = false;
                    }
                }
                if (count == true)
                {
                    test = Convert.ToDouble(A);
                    // Console.WriteLine(test);
                    Console.WriteLine("Коэффициент введен правильно");
                    count = false;
                }
                else
                {
                    Console.WriteLine("Не правильно");
                    A = Console.ReadLine();
                    count = true;
                    count_for_point = 0;
                }
            }
        }
        static void Main(string[] args)
        {
            Double A = 0, B = 0, C = 0;
            Console.Write("Введите коэффициент A:");
            CheckName(ref A);
            Console.Write("Введите коэффициент B:");
            CheckName(ref B);
            Console.Write("Введите коэффициент C:");
            CheckName(ref C);
            if (Discriminant(ref A, ref B, ref C) < 0)
            {
                Console.Write("Дискриминант меньше 0, корней нет");
            }
            else
            {

            }
            /*Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);*/
            Console.ReadKey();




        }
    }
}

using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace lab6_part1
{
    delegate int DvisionAnddivisionWithRemainder(int p1, int p2);
    class Program
    {
            static int Division(int p1, int p2) 
            { 
                return p1 / p2; 
            }
            static int DivisionWithReminder(int p1, int p2) 
            {
                return p1 % p2; 
            }
            static void DvisionAnddivisionWithRemainderFunc(string str, int i1, int i2, Func<int, int, int> DvisionAnddivisionWithRemainderParam)
            {
                int Result = DvisionAnddivisionWithRemainderParam(i1, i2);
                Console.WriteLine(str + Result.ToString());
            }

            static void DvisionAnddivisionWithRemainderMethod(string str, int i1, int i2, DvisionAnddivisionWithRemainder DvisionAnddivisionWithRemainderParam)
            {
                int Result = DvisionAnddivisionWithRemainderParam(i1, i2);
                Console.WriteLine(str + Result.ToString());
            }

            static void Main(string[] args)
            {
                int i1 = 12;
                int i2 = 5;

            DvisionAnddivisionWithRemainderMethod("Деление: ", i1, i2, Division);
            DvisionAnddivisionWithRemainderMethod("Длеение с остатком: ", i1, i2, DivisionWithReminder);
            DvisionAnddivisionWithRemainder pm1 = new DvisionAnddivisionWithRemainder(Division);
            DvisionAnddivisionWithRemainderMethod("Создание экземпляра делегата на основе метода: ", i1, i2, pm1);
            DvisionAnddivisionWithRemainder pm2 = Division;
            DvisionAnddivisionWithRemainderMethod("Создание экземпляра делегата на основе 'предположения' делегата: ", i1, i2, pm2);
            DvisionAnddivisionWithRemainder pm3 = delegate (int param1, int param2)
                {
                    return param1 / param2;
                };
            DvisionAnddivisionWithRemainderMethod("Создание экземпляра делегата на основе анонимного метода: ", i1, i2, pm2);
            DvisionAnddivisionWithRemainderMethod("Создание экземпляра делегата на основе лямбда-выражения 1: ", i1, i2,
                    (int x, int y) =>
                    {
                        int z = x / y;
                        return z;
                    }
                    );
            DvisionAnddivisionWithRemainderMethod("Создание экземпляра делегата на основе лямбда-выражения 2: ", i1, i2,
                    (x, y) =>
                    {
                        return x / y;
                    }
                    );
            DvisionAnddivisionWithRemainderMethod("Создание экземпляра делегата на основе лямбда-выражения 3: ", i1, i2, (x, y) => x + y);
                Console.WriteLine("\n\nИспользование обощенного делегата Func<>");
            DvisionAnddivisionWithRemainderFunc("Создание экземпляра делегата на основе метода: ", i1, i2, Division);
                string OuterString = "ВНЕШНЯЯ ПЕРЕМЕННАЯ";
            DvisionAnddivisionWithRemainderFunc("Создание экземпляра делегата на основе лямбда-выражения 1: ", i1, i2,
                    (int x, int y) =>
                    {
                        Console.WriteLine("Эта переменная объявлена вне лямбда-выражения: " + OuterString);
                        int z = x / y;
                        return z;
                    }
                    );

            DvisionAnddivisionWithRemainderFunc("Создание экземпляра делегата на основе лямбда-выражения 2: ", i1, i2,
                    (x, y) =>
                    {
                        return x / y;
                    }
                    );

            DvisionAnddivisionWithRemainderFunc("Создание экземпляра делегата на основе лямбда-выражения 3: ", i1, i2, (x, y) => x + y);
                Console.WriteLine("Пример группового делегата");
                Action<int, int> a1 = (x, y) => { Console.WriteLine("{0} / {1} = {2}", x, y, x / y); };
                Action<int, int> a2 = (x, y) => { Console.WriteLine("{0} % {1} = {2}", x, y, x % y); };
                Action<int, int> group = a1 + a2;
                group(9, 3);
                Action<int, int> group2 = a1;
                Console.WriteLine("Добавление вызова метода к групповому делегату");
                group2 += a2;
                group2(3, 3);
                Console.WriteLine("Удаление вызова метода из группового делегата");
                group2 -= a1;
                group2(3, 2);

                Console.ReadLine();
            }
        
    }
}
   


﻿using System;
using System.Reflection;

namespace lab6_part2
{
    class Program
    {
        public static bool GetPropertyAttribute(PropertyInfo checkType, Type attributeType, out object attribute)
        {
            bool Result = false;
            attribute = null;

            //Поиск атрибутов с заданным типом
            var isAttribute = checkType.GetCustomAttributes(attributeType, false);
            if (isAttribute.Length > 0)
            {
                Result = true;
                attribute = isAttribute[0];
            }

            return Result;
        }
          static void Main(string[] args)
        {
                Type t = typeof(Rectangle);

                Console.WriteLine("Тип " + t.FullName + " унаследован от " + t.BaseType.FullName);
                Console.WriteLine("Пространство имен " + t.Namespace);
                Console.WriteLine("Находится в сборке " + t.AssemblyQualifiedName);

                Console.WriteLine("\nКонструкторы:");
                foreach (var x in t.GetConstructors())
                {
                    Console.WriteLine(x);
                }

                Console.WriteLine("\nМетоды:");
                foreach (var x in t.GetMethods())
                {
                    Console.WriteLine(x);
                }

                Console.WriteLine("\nСвойства:");
                foreach (var x in t.GetProperties())
                {
                    Console.WriteLine(x);
                }

                Console.WriteLine("\nПоля данных (public):");
                foreach (var x in t.GetFields())
                {
                    Console.WriteLine(x);
                }

                Console.WriteLine("\nСвойства, помеченные атрибутом:");
                foreach (var x in t.GetProperties())
                {
                    object attrObj;
                    if (GetPropertyAttribute(x, typeof(NewAttribute), out attrObj))
                    {
                        NewAttribute attr = attrObj as NewAttribute;
                        Console.WriteLine(x.Name + " - " + attr.Description);
                    }
                }

                Console.WriteLine("\nВызов метода:");

                //Создание объекта
                //ForInspection fi = new ForInspection();

                //Можно создать объект через рефлексию
                Rectangle fi = (Rectangle)t.InvokeMember(null, BindingFlags.CreateInstance, null, null, new object[] { });

                //Параметры вызова метода
                object[] parameters = new object[] { 6, 2 };

                //Вызов метода
                object Result = t.InvokeMember("Division", BindingFlags.InvokeMethod, null, fi, parameters);
                Console.WriteLine("Division(6,2)={0}", Result);

                Console.ReadLine();
         }
        
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GorovenkoGV.Sprint2.Task1.V28.Lib;

namespace Tyuiu.GorovenkoGV.Sprint2.Task1.V28
//int a = 247;
//int b = 654;
//int c = 671;
//int d = 671;
//true, false, true, false, true, false
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Горовенко Г.В. | ПКТб 23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Логические операции                                               *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнил: Горовенко Глеб Васильевич | ПКТб-23-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,         *");
            Console.WriteLine("* последовательность можно чередовать, но использовать один раз в         *");
            Console.WriteLine("* выражении) и логических операций (|, &, ||, &&, !, ^,                   *");
            Console.WriteLine("* последовательность операций не должна нарушаться), а также              *");
            Console.WriteLine("* арифметических выражений, которая вернет логическую последовательность  *");
            Console.WriteLine("* (массив): (True, False, True, False, True, False), при a = 247, b =     *");
            Console.WriteLine("* 654, c = 671, d = 671                                                   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИССХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("***************************************************************************");

            int a = 247;
            int b = 654;
            int c = 671;
            int d = 671;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            Console.WriteLine("A = " + a);
            Console.WriteLine("B = " + b);
            Console.WriteLine("C = " + c);
            Console.WriteLine("D = " + d);



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadKey();
        }
    }
}

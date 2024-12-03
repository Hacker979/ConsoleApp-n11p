using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_n11p
{
    class Program
    {
        static int Max(int a, int b)
        {
            return a > b ? a : b;
        }
        static void Swap(ref int a, ref int b, ref int c)
        {
            int max = Max(Max(a, b),c);
            int p = a;
            a = b;
            b = p;
        }
        static int Input(string a)
        {
            Console.Write(a);
            return int.Parse(Console.ReadLine());
        }
        /// <summary>
        /// Задача 3. Ввести три целых числа и вывести их в порядке возрастания значений.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int a = Input("Введите 1 число:");
            int b = Input("Введите 2 число:");
            int c = Input("Введите 3 число:");

            Console.WriteLine($"до изменений {a} {b} {c}");
            Swap(ref a, ref b, ref c);
            Console.Write($"после изменений {a} {b} {c}");
            Console.Read();
        }
    }
}

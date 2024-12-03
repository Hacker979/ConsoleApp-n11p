using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_n11p
{
    class Program
    {
        static void swap(ref string x, ref string y)
        {
            string p = x;
            x = y;
            y = p;
        }
        /// <summary>
        /// Задача 1. Поменять местами содержимое двух строковых переменных.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string st1 = "привет";
            string st2 = "пока";
            Console.WriteLine($"до изменений {st1} {st2}");
            swap(ref st1, ref st2);
            Console.Write($"после изменений {st1} {st2}");
            Console.Read();
        }
    }
}

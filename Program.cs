using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_n11p
{
    class Program
    {
        static void Swap(ref int a, ref int b)
        {
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
        /// Задача 2. Составить программу,
        /// в результате которой величина а меняется значением с величиной b,
        /// а величина c — с величиной d.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int a = Input("Введите 1 число:");
            int b = Input("Введите 2 число:");
            int c = Input("Введите 3 число:");
            int d = Input("Введите 4 число:");

            Console.WriteLine($"до изменений {a} {b} {c} {d}");
            Swap(ref a, ref b);
            Swap(ref c, ref d);
            Console.Write($"после изменений {a} {b} {c} {d}");
            Console.Read();
        }
    }
}

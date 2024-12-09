using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_n11p
{
    class Program
    {
        static int MaxTwo(int a, int b)
        {
            return a > b ? a : b; // Возвращает большее из двух чисел
        }

        static int FindMax(int a, int b, int c, int d, int e, int f, int g, int h)
        {
            int max1 = MaxTwo(a, b);
            int max2 = MaxTwo(c, d);
            int max3 = MaxTwo(e, f);
            int max4 = MaxTwo(g, h);
            int max = MaxTwo(max1, MaxTwo(max2, MaxTwo(max3, max4)));
            return max;
        }

        // Метод для ввода числа
        static int Input(string prompt)
        {
            Console.Write(prompt);
            return int.Parse(Console.ReadLine());
        }
        /// <summary>
        /// Задача 2. Даны 8 различных чисел. Определить максимальное из них, используя функцию определения максимального из двух чисел.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int a = Input("Введите 1 число: ");
            int b = Input("Введите 2 число: ");
            int c = Input("Введите 3 число: ");
            int d = Input("Введите 4 число: ");
            int e = Input("Введите 5 число: ");
            int f = Input("Введите 6 число: ");
            int g = Input("Введите 7 число: ");
            int h = Input("Введите 8 число: ");

            int max = FindMax(a, b, c, d, e, f, g, h);
            Console.WriteLine($"Максимальное число: {max}");
            Console.ReadLine();
        }
    }
}

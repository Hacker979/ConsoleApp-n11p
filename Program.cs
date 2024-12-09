using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_n11p
{
    class Program
    {
        static double Input(string sideName)
        {
            Console.Write($"{sideName}: ");
            return double.Parse(Console.ReadLine());
        }

        static double P(double a, double b, double c)
        {
            return a + b + c;
        }

        static double S(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        static void Sum(double a1, double b1, double c1, double a2, double b2, double c2)
        {
            double p1 = P(a1, b1, c1);
            double s1 = S(a1, b1, c1);
            double p2 = P(a2, b2, c2);
            double s2 = S(a2, b2, c2);

            double totalP = p1 + p2;
            double totalS = s1 + s2;

            Console.WriteLine($"Сумма периметров: {totalP}");
            Console.WriteLine($"Сумма площадей: {totalS}");
        }
        /// <summary>
        /// Задача 5. Даны стороны двух треугольников. Найти сумму их периметров и сумму их площадей.
        /// (Определить вспомогательный метод для расчета периметра и площади треугольника по его сторонам.)
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны первого треугольника:");
            double a1 = Input("Сторона a");
            double b1 = Input("Сторона b");
            double c1 = Input("Сторона c");

            Console.WriteLine("Введите стороны второго треугольника:");
            double a2 = Input("Сторона a");
            double b2 = Input("Сторона b");
            double c2 = Input("Сторона c");

            Sum(a1, b1, c1, a2, b2, c2);

            Console.ReadLine();
        }
    }
}

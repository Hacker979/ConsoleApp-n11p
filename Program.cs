using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_n11p
{
    class Program
    {
        static double Input(string msg)
        {
            Console.Write(msg);
            return double.Parse(Console.ReadLine());
        }
        static double Dist(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        static double P(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            double side1 = Dist(x1, y1, x2, y2);
            double side2 = Dist(x2, y2, x3, y3);
            double side3 = Dist(x3, y3, x1, y1);
            return side1 + side2 + side3;
        }
        /// <summary>
        /// Задача 6. Найти периметр треугольника, заданного координатами своих вершин.
        /// (Определить функцию для расчета длины отрезка по координатам его вершин.)
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            double x1 = Input("Введите x1: ");
            double y1 = Input("Введите y1: ");
            double x2 = Input("Введите x2: ");
            double y2 = Input("Введите y2: ");
            double x3 = Input("Введите x3: ");
            double y3 = Input("Введите y3: ");

            double perimeter = P(x1, y1, x2, y2, x3, y3);
            Console.WriteLine($"Периметр треугольника: {perimeter}");
            Console.ReadLine();
        }
    }
}

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

        static double Area(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            return Math.Abs(x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) / 2;
        }

        static double P(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4, double x5, double y5)
        {
            double area1 = Area(x1, y1, x2, y2, x3, y3);
            double area2 = Area(x1, y1, x3, y3, x4, y4);
            double area3 = Area(x1, y1, x4, y4, x5, y5);
            return area1 + area2 + area3;
        }
        /// <summary>
        /// Задача 1. Написать программу определения площади пятиугольника с заданными координатами его вершин (x1,y1), (x2,y2), (x3,y3), (x4,y4), (x5,y5)
        /// как сумму площадей трех треугольников. Площадь треугольника, определенную по координатам вершин, рассчитать с помощью функции.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            double x1 = Input("x1: ");
            double y1 = Input("y1: ");
            double x2 = Input("x2: ");
            double y2 = Input("y2: ");
            double x3 = Input("x3: ");
            double y3 = Input("y3: ");
            double x4 = Input("x4: ");
            double y4 = Input("y4: ");
            double x5 = Input("x5: ");
            double y5 = Input("y5: ");

            double area = P(x1, y1, x2, y2, x3, y3, x4, y4, x5, y5);
            Console.WriteLine($"Площадь пятиугольника: {area}");
            Console.ReadLine();
        }
    }
}

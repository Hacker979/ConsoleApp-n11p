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

        static string Type(double a, double b, double c)
        {
            if (a == b && b == c)
                return "Равносторонний";
            if (a == b || b == c || a == c)
                return "Равнобедренный";
            if (a * a + b * b == c * c || b * b + c * c == a * a || a * a + c * c == b * b)
                return "Прямоугольный";
            return "Обычный";
        }
        /// <summary>
        /// Задача 3. Треугольник задан координатами его вершин. Определить вид треугольника (равнобедренный, равносторонний ,
        /// прямоугольный или обычный). Длину стороны определять с помощью функции.
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

            double a = Dist(x1, y1, x2, y2);
            double b = Dist(x2, y2, x3, y3);
            double c = Dist(x3, y3, x1, y1);

            string type = Type(a, b, c);
            Console.WriteLine($"Тип треугольника: {type}");
            Console.ReadLine();
        }
    }
}

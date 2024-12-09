using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_n11p
{
    class Program
    {
        static void CalculateCircle(double r)
        {
            double s = 3.14 * r * r;
            double cs = 2 * 3.14 * r;
            Console.WriteLine($"Радиус: {r}");
            Console.WriteLine($"Площадь круга: {s}");
            Console.WriteLine($"Длина окружности: {cs}");
        }
        /// <summary>
        /// Задача 4. Создать метод, который будет вычислять площадь круга и длину окружности.
        /// Вызывающий программный код должен передавать в качестве аргумента методу значение радиуса и печатать значение радиуса,
        /// площади круга и длины окружности.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            double r = 5;
            CalculateCircle(r);
            Console.ReadLine();
        }
    }
}

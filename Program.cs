using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите диаметр окружности");
            int diametr = int.Parse(Console.ReadLine());
            const double P=3.14;
            var length = diametr * P;
            var radius = diametr / 2;
            var square = P * (radius * radius);
            Console.WriteLine($"Длина окружности: {length}");
            Console.WriteLine($"Площадь круга: {square}");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус окружности");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату x центра окружности");
            double x0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату y центра окружности");
            double y0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Задайте координату x точки");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Задайте координату y точки");
            double y = Convert.ToDouble(Console.ReadLine());
            double square = Circle.GetSquare(r);
            double lenght = Circle.GetLenght(r);
            string point = Circle.GetPoint(r, x0, y0, x, y);
            Console.WriteLine($"Площадь круга равна {square:f2} \nДлина окружности равна {lenght:f2} \n {point}");
            Console.ReadKey();
        }
    }
}

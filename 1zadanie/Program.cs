using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac44
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите 1 сторону прямоугольника: ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите 2 сторону прямоугольника: ");
            double side2 = Convert.ToDouble(Console.ReadLine());
            Rectangle rect1 = new Rectangle(side1, side2);

            Console.WriteLine($"Периметр прямоугольника {rect1.Perimeter}");
            Console.WriteLine($"Площадь прямоугольника {rect1.Area}");

            Console.Read();
        }
    }
}

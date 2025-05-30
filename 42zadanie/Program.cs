using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle<int> triangle = new Triangle<int>(3, 4, 5);
            triangle.Print();
            Console.WriteLine($"Площадь: {triangle.Area():F2}");

            Triangle<double> triangle2 = new Triangle<double>(1, 2, 10); // невалидный треугольник
            triangle2.Print();
            Console.WriteLine($"Площадь: {triangle2.Area():F2}"); // будет NaN

            Console.ReadLine();


        }
    }
}

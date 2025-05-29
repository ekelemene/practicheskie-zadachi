using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Пример создания треугольника
            Point p1 = new Point(0, 0, "A");
            Point p2 = new Point(0, 3, "B");
            Point p3 = new Point(4, 0, "C");
            Figure triangle = new Figure(p1, p2, p3);
            triangle.PerimeterCalculator();

            // Пример создания четырехугольника
            Point p4 = new Point(0, 0, "A");
            Point p5 = new Point(0, 4, "B");
            Point p6 = new Point(4, 4, "C");
            Point p7 = new Point(4, 0, "D");
            Figure quadrilateral = new Figure(p4, p5, p6, p7);
            quadrilateral.PerimeterCalculator();

            // Пример создания пятиугольника
            Point p8 = new Point(0, 0, "A");
            Point p9 = new Point(0, 3, "B");
            Point p10 = new Point(2, 4, "C");
            Point p11 = new Point(4, 3, "D");
            Point p12 = new Point(4, 0, "E");
            Figure pentagon = new Figure(p8, p9, p10, p11, p12);
            pentagon.PerimeterCalculator();
            Console.Read();



        }
    }
}

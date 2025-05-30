using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Point<int> p1 = new Point<int>(10,20);
            Point<uint> p2 = new Point<uint>(100u, 200u);
            Point<double> p3 = new Point<double>(1.2, 3.5);

            p1.Output();
            Console.WriteLine();
            p2.Output();
            Console.WriteLine();
            p3.Output();
            Console.Read();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41zadanie
{
    class Point<T>
    {
        private T x;
        private T y;
        public T X { get => x; set => x = value; }
        public T Y { get => y; set => y = value; }

        public Point(T x,T y)
        {
            this.X = x;
            this.Y = y;
        }
        public void Output()
        {
            Console.WriteLine($"x: {X}");
            Console.WriteLine($"y: {Y}");
        }

    }
}

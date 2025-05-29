using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie3
{
    class Point
    {
        int x { get; }
        int y { get; }
        string name { get; }

        public Point(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }
        public int X { get { return x; } }
        public int Y {get { return y; } }
        public string Name { get { return name; } }

    }
}

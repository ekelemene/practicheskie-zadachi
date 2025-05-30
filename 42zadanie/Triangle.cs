using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42zadanie
{
    /// <summary>
    /// обобщенный класс треугольник
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class Triangle<T>
    {
        /// <summary>
        /// поля
        /// </summary>
        T a;
        T b;
        T c;
        /// <summary>
        /// конструктор с 3 параметрами 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public Triangle(T a, T b, T c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }
        /// <summary>
        /// свойтсва с доп логикой
        /// </summary>
        public T A { get { return a; } set { a = value; } }
        public T B { get { return b; } set { b = value; } }
        public T C { get { return c; } set { c = value; } }
        /// <summary>
        /// метод для вывода информации о треуголльнике
        /// </summary>
        public void Print()
        {
            Console.WriteLine($"A: {A}");
            Console.WriteLine($"B: {B}");
            Console.WriteLine($"C: {C}");
        }
        /// <summary>
        /// метод для нахождения площади треугольника
        /// </summary>
        /// <returns></returns>
        public double Area() 
        {
            double aDouble = Convert.ToDouble(A);
            double bDouble = Convert.ToDouble(B);
            double cDouble = Convert.ToDouble(C);

            double s = (aDouble + bDouble + cDouble) / 2;
            return Math.Sqrt(s * (s - aDouble) * (s - bDouble) * (s - cDouble));
        }



    }
}

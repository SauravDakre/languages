using System;
using Program.Math;

namespace Program
{
    class Prog
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello non primitive types");
            var a = new Person();
            a.fn = "first";
            a.ln = "last";
            a.Introduce();

            Console.WriteLine(Calculator.add(2, 3));

            var pt = new Point(1, 2);
            Console.WriteLine(pt);
            pt.SetOrigin();
            Console.WriteLine(pt);
        }
    }

    public struct Point
    {
        public int X,Y;
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }

        public void SetOrigin()
        {
            X = 0;
            Y = 0;
        }
    }
}
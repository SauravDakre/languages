using System;
using Program.Math;

namespace Program
{
    class Prog
    {
        static void Main(string[] args)
        {
            Console.WriteLine("non primitive types");

            // class example
            var a = new Person();
            a.fn = "first";
            a.ln = "last";
            a.Introduce();

            Console.WriteLine(Calculator.add(2, 3));

            // struct example
            var pt = new Point(1, 2);
            Console.WriteLine(pt);
            pt.SetOrigin();
            Console.WriteLine(pt);

            // Array example
            var ar = new int[4];
            ar[0] = 1;
            Console.WriteLine(ar);
            ar[1] = 2;
            Console.WriteLine($"{ar[0]}, {ar[1]}, {ar[2]}, {ar[3]}");

            var strs = new string[2] { "a", "b" };
            Console.WriteLine($"{strs[0]}, {strs[1]}");

            // strings
            var fn = "first name";
            var ln = "last name";
            var fullName = fn + " " + ln;
            Console.WriteLine(fullName);
            var fullName2 = string.Format("{0} {1}", fn, ln);
            Console.WriteLine(fullName2);
            var txt = @"hi
            how
            are
you?";
            Console.WriteLine(txt);

            // enum
            // working with int
            Console.WriteLine((int)ShippingMethods.Express);
            var methodId = 2;
            Console.WriteLine((ShippingMethods)methodId);

            // working with string
            Console.WriteLine(ShippingMethods.Registered);
            var method = "Express";
            Console.WriteLine((ShippingMethods) Enum.Parse(typeof(ShippingMethods), method));


            // reference type and value types
            // struct is value type, class is reference type
            var pt2 = pt;
            Console.WriteLine($"pt:{pt}, pt2: {pt2}");
            pt2.Y = 5;
            pt2.X = 5;
            Console.WriteLine($"pt:{pt}, pt2: {pt2}");

            var b = a;
            Console.WriteLine($"a:{a}, b:{b}");
            b.fn = "harry";
            b.ln = "sandu";
            Console.WriteLine($"a:{a}, b:{b}");

        }
    }

    // enum
    public enum ShippingMethods
    {
        Regular=1,
        Registered=2,
        Express=3
    }

    // struct
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
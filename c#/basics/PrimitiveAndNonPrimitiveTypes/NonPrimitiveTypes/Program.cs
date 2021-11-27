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
        }
    }
}
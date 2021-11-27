using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello 1");
            // variables and constants
            int num1;
            // Console.WriteLine(num1); // we cannot print unassigned variable

            int n = 10;
            float num2 = 20.5f; // explicitly tell compiler by appending f to number to tell its float
            char character = 'q';
            string str = "hello";
            bool flag = false;
            Console.WriteLine(n);
            Console.WriteLine(num2);
            Console.WriteLine(character);
            Console.WriteLine(str);
            Console.WriteLine(flag);

            var n2 = 20.5;
            Console.WriteLine(n2);

            checked   // doesnot allow overflow at runtime, instead throw exception
            {
                byte num = 255;
                Console.WriteLine(num+1);
            }

            Console.WriteLine("{0}, {1}", byte.MinValue, byte.MaxValue);

            Console.WriteLine($"{float.MaxValue}, {float.MinValue}");

            const float pi = 3.14f;
            // pi = 1; cannot change value of const

        }
    }
}
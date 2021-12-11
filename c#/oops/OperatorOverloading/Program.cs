namespace OperatorOverloading
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("operator overloading");

            Fraction x = new Fraction(1,2);
            Fraction y = new Fraction(2,5);

            System.Console.WriteLine(x+y);

            var a = new Fraction(5, 4);
            var b = new Fraction(1, 2);
            Console.WriteLine(-a);   // output: -5 / 4
            Console.WriteLine(a + b);  // output: 14 / 8
            Console.WriteLine(a - b);  // output: 6 / 8

            Console.WriteLine(x == b);
            Console.WriteLine(x == a);

            Console.WriteLine(new Fraction(0,0));
        }
        
    }
}
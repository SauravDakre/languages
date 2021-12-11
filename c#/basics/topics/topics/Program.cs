namespace Topics
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("namespace example");

            n1.c1.info();
            n2.c2.info();
            nn1.nn2.c1.info();

            TryException.tryExc();
            TryException.tryCatchFinally();
        }
    }
}
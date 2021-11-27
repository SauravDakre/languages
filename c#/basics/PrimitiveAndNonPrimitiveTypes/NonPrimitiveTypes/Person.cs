using System;

namespace Program
{
    public class Person
    {
        public string fn;
        public string ln;

        public void Introduce()
        {
            Console.WriteLine($"{fn}, {ln}");
        }
    }
}

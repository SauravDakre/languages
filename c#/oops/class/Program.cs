namespace TryClass{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("hello");
            var p = Person.Parse("joy");
            p.IntroduceTo("roy");

            // object initialization
            var p1 = new Person()
            {
                Name = "parth",
                Age = 20
            };
            p1.IntroduceTo("joy");

            var c = new Customer(1, "joy");
            Console.WriteLine($"{c.Id}, {c.Name}");
        }
    }
}
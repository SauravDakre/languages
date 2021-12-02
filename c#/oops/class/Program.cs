namespace TryClass
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("hello");
            var p = Person.Parse("joy");
            p.IntroduceTo("roy");

            // object initialization
            var p1 =
                new Person("parth",
                    "parth",
                    new DateTime(2000, 1, 1))
                { CityCode = 1 };
            p1.IntroduceTo("joy");
            System.Console.WriteLine($"age: {p1.Age}");

            var c = new Customer(1, "joy");
            Console.WriteLine($"{c.Id}, {c.Name}");

            overloadingExample();

            System.Console.WriteLine(AddNums(1, 2, 3, 4));
            System.Console.WriteLine(AddNums(new int[] { 1, 2, 3, 4, 5 }));

            var indexer = new TryIndexer();
            indexer["key1"] = "value1";
            System.Console.WriteLine(indexer["key1"]);
        }

        public static void overloadingExample()
        {
            Point pt = new Point(1, 1);
            var pt2 = new Point(5, 5);
            pt.Move (pt2);
            System.Console.WriteLine (pt);
            pt.Move(7, 7);
            System.Console.WriteLine (pt);
        }

        public static int AddNums(params int[] nos)
        {
            int sum = 0;
            foreach (int no in nos)
            {
                sum += no;
            }
            return sum;
        }
    }
}

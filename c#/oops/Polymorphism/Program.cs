namespace TryPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("polymorphism");

            List<Shapes> shapes = new List<Shapes>();
            shapes.Add(new Rectangle());
            shapes.Add(new Cirlce());
            shapes.Add(new Triangle());
            overridingExample(shapes);
            OverloadingExmple();
            AbstractClassExample();
        }

        static void AbstractClassExample()
        {
            var person = new Person();
            person.Name = "abc";
            person.Eat();
            person.Speak();
        }

        static void OverloadingExmple()
        {
            var cal = new Calculator();
            Console.WriteLine(cal.Add(5,2));
            Console.WriteLine(cal.Add(2, 5, 7));
            Console.WriteLine(cal.Add(1.1, 7.1));
            Console.WriteLine(cal.Add(1, 7.1));
        }
        static void overridingExample(List<Shapes> shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }

    }
}
namespace TryClass
{
    class Animal
    {
        public string Name { get; set; }

        public void Eat()
        {
            System.Console.WriteLine($"{Name} is eating");
        }
    }
}

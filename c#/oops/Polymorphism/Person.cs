namespace TryPolymorphism
{
    class Person: Animal
    {
        public override void Eat()
        {
            Console.WriteLine($"{Name} is eating");
        }
    }
}
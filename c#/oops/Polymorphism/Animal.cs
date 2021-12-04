namespace TryPolymorphism
{
    abstract class Animal
    {
        public string Name { get; set; }

        public abstract void Eat();

        public void Speak()
        {
            Console.WriteLine("animal is speaking");
        }
    }
}


namespace TryPolymorphism
{
    class Shapes
    {
        public int X { get; set; }
        public int Y { get; set; }

        public virtual void Draw() 
        {
            Console.WriteLine("shapes draw method called");
        }
    }
}

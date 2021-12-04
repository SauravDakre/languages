namespace TryInheritance
{
    class Shapes
    {
        private int _noOfSides;
        protected string Name;

        public Shapes(int noOfSides)
        {
            _noOfSides = noOfSides;
        }

        protected void Describe()
        {
            Console.WriteLine("describe-----");
        }

        protected internal void Info()
        {
            Console.WriteLine($"{Name} has {_noOfSides} sides");
        }
    }
}

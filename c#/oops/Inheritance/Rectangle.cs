namespace TryInheritance
{
    class Rectangle : Shapes
    {
        public Rectangle(int noOfSides, string name):base(noOfSides)
        {
            Name = name;
        }

        public void BaseInfo()
        {
            Describe();
            Info();
        }
    }
}


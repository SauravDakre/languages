namespace TryClass
{
    class Lion
    {
        private Walkable _walkable;

        public string Name;

        public Lion(Walkable walkable, string name)
        {
            _walkable = walkable;
            Name = name;
        }

        public void Move()
        {
            _walkable.Walk (Name);
        }
    }
}

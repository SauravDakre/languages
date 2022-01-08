namespace crud.Entities
{
    public class People
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public People(int id, int age, string name)
        {
            Id = id;
            Name = name;
            Age = age;
        }
    }
}

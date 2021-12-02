namespace TryClass
{
    public class Person
    {
        public string Name;

        public string UserName { get; set; }

        public DateTime BirthDate { get; private set; }

        public int CityCode { get; set; }

        public readonly List<string> Orders = new List<string>();

        public Person()
        {
            this.Name = "";
            this.UserName = "";
        }

        public Person(String name, String userName, DateTime dt)
        {
            this.Name = name;
            this.UserName = userName;
            this.BirthDate = dt;
        }

        public int Age
        {
            get
            {
                var ts = DateTime.Today - this.BirthDate;
                return ts.Days / 365;
            }
        }

        public void IntroduceTo(string str)
        {
            Console.WriteLine($"hello {str}, I am {Name}");
        }

        public static Person Parse(string str)
        {
            Person person = new Person();
            person.Name = str;
            return person;
        }
    }
}

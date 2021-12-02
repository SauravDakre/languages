namespace TryClass
{
    public class Person
    {
        public string Name;
        public int Age;
        public List<string> Orders;

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

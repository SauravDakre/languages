namespace TryClass
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<string> Orders;

        public Customer()
        {
            Orders = new List<string>();
        }

        public Customer(int id): this()
        {
            this.Id = id;
        }

        public Customer(int id, string name): this(id)
        {
            this.Name = name;
        }

    }
}

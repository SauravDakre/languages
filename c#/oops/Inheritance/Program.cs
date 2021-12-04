using TryClass;

namespace TryInheritance
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("hellow");

            PublicAccessModifiers();
            ProtectedAccessModifier();
            casting();
        }

        static void casting()
        {
            Animal animal = new Dog(); // upcasting
            animal.Name = "shiro";
            animal.Eat();
            //animal.Bark(); // cannot be called

            downCasting(animal);
        }

        static void downCasting(Animal animal)
        {
            Dog dog = (Dog)animal; // downCasting
            dog.Bark();

            var dg = animal as Dog;
            if(dg != null)
            {
                dg.Bark();
            }
        }

        static void ProtectedAccessModifier()
        {
            var rect = new Rectangle(4, "rectangle");
            rect.BaseInfo();
        }

        public static void PublicAccessModifiers()
        {
            var dog = new Dog();
            dog.Name = "shiro";
            dog.Eat();
            dog.Bark();
        }
    }
}

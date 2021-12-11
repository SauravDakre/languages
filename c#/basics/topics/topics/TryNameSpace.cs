
namespace n1
{
    class c1
    {
        public static void info()
        {
            Console.WriteLine("inside n1 c1");
        }
    }
}

namespace n2
{
    class c2
    {
        public static void info()
        {
            Console.WriteLine("inside n2 c2");
        }
    }
}

namespace nn1
{
    namespace nn2
    {
        class c1
        {
            public static void info()
            {
                Console.WriteLine("inside nn1 nn2 c1");
            }
        }
    }
}

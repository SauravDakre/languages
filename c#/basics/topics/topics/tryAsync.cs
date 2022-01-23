using System.Threading.Tasks;

namespace Topics
{
    class TryAsync
    {
        public static async Task<int> GetNumAsync()
        {
            System.Console.WriteLine("getnumasync func");
            await Task.Delay(100);
            return 1;
        }

        public static async Task JustAsnyc()
        {
            System.Console.WriteLine("justAsync func");
            return;
        }

        public static async Task DoWork(string s, int sleep)
        {
            System.Console.WriteLine($"{s} is sleeping for {sleep}");
            await Task.Delay(sleep);
            return;
        }
    }
}

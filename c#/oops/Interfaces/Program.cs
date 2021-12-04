namespace Interfaces
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("interfaces");
            var task = new Task(new ConsoleLogger());
            task.RegisterNotificationChannel(new SMSNotifier());
            task.Do();

            string path = $"{Directory.GetCurrentDirectory()}\\log.txt";

            var task2 = new Task(new FileLogger(path));
            task2.RegisterNotificationChannel(new SMSNotifier());
            task2.RegisterNotificationChannel(new EmailNotifier());
            task2.Do();
        }
    }

    public interface ILogger
    {
        void Info(string message);
    }
}
namespace Interfaces
{
    class EmailNotifier: INotificationChannel
    {
        public void Notify()
        {
            Console.WriteLine("sent email...");
        }
    }
}

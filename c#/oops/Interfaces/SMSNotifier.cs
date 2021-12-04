namespace Interfaces
{
    class SMSNotifier: INotificationChannel
    {
        public void Notify()
        {
            Console.WriteLine("sent sms...");
        }
    }
}

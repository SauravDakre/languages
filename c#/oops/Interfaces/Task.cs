namespace Interfaces
{
    class Task
    {
        private ILogger _ilogger;
        private List<INotificationChannel> _notificationChannels;

        public Task(ILogger logger)
        {
            _ilogger = logger;
            _notificationChannels = new List<INotificationChannel>();
        }

        public void Do()
        {
            _ilogger.Info("started doing task");
            _ilogger.Info("completed doing task");

            foreach(var channel in _notificationChannels)
            {
                channel.Notify();   // interface showing polymorphic behaviour as channel can be smsNotifier or emailNotifier
            }
        }

        public void RegisterNotificationChannel(INotificationChannel notificationChannel)
        {
            _notificationChannels.Add(notificationChannel);
        }
    }
}

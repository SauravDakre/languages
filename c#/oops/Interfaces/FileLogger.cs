namespace Interfaces
{
    class FileLogger: ILogger
    {
        private string _path;

        public FileLogger(string path)
        {
            _path = path;
        }
        public void Info(string message)
        {
            using(var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine("INFO: " + message);
            }
        }
    }
}

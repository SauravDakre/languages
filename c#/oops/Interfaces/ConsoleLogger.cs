using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class ConsoleLogger: ILogger
    {
        public void Info(string message)
        {
            Console.WriteLine("INFO: "+message);
        }
    }
}

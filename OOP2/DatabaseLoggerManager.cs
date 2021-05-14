using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class DatabaseLoggerManager : ILoggerManager
    {
        public void Logger()
        {
            Console.WriteLine("Database'e Loglandı!");
        }
    }
}

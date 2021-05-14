using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class SmsLoggerManager : ILoggerManager
    {
        public void Logger()
        {
            Console.WriteLine("Sms ile loglandı!");
        }
    }
}

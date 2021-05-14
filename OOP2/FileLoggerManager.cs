using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class FileLoggerManager : ILoggerManager
    {
        public void Logger()
        {
            Console.WriteLine("Dosyaya Loglandı!");
        }
    }
}

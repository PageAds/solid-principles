using System;
using System.IO;

namespace SingleReponsibility.GoodWay
{
    public class FileLogger
    {
        public void Log(string message)
        {
            File.WriteAllText(@"C:\Temp\logger.txt", message);
        }
    }
}

using System;
using SimpleIoC.Interface;

namespace SimpleIoC.Implement
{
    public class Logger : ILogger
    {
        public void LogInfo(string info)
        {
            Console.WriteLine("Write Real Log");
        }
    }
}
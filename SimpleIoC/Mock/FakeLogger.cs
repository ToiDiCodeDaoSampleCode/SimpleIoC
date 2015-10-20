using System;
using SimpleIoC.Interface;

namespace SimpleIoC.Mock
{
    class FakeLogger : ILogger
    {
        public void LogInfo(string info)
        {
            Console.WriteLine("Fake log");
        }
    }
}

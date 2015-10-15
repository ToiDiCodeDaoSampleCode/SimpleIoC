using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleIoC
{
    class FakeLogger : ILogger
    {
        public void LogInfo(string info)
        {
            throw new NotImplementedException();
        }
    }
}

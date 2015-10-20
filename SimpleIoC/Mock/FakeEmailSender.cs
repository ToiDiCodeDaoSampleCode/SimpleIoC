using System;
using SimpleIoC.Interface;

namespace SimpleIoC.Mock
{
    class FakeEmailSender : IEmailSender
    {
        public void SendEmail(int userId)
        {
            Console.WriteLine("Send fake email");
        }
    }
}

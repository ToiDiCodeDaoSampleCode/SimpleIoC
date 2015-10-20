using System;
using SimpleIoC.Interface;

namespace SimpleIoC.Implement
{
    public class EmailSender : IEmailSender
    {
        public void SendEmail(int userId)
        {
            Console.WriteLine("Send real email");
        }
    }
}
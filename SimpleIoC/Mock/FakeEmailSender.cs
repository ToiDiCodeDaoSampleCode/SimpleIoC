using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleIoC
{
    class FakeEmailSender : IEmailSender
    {
        public void SendEmail(int userId)
        {
            throw new NotImplementedException();
        }
    }
}

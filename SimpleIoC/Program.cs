using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleIoC
{
    class Program
    {
        static void Main(string[] args)
        {
            Cart myCart = new Cart(new Database(), new Logger(), new EmailSender());
            //Khi cần thay đổi database, logger
            myCart = new Cart(new XMLDatabase(), new FakeLogger(), new FakeEmailSender());
        }
    }

    public class Cart
    {
        private readonly IDatabase _db;
        private readonly ILogger _log;
        private readonly IEmailSender _es;

        public Cart(IDatabase db, ILogger log, IEmailSender es)
        {
            _db = db;
            _log = log;
            _es = es;
        }

        public void Checkout(int orderId, int userId)
        {
            _db.Save(orderId);
            _log.LogInfo("Order has been checkout");
            _es.SendEmail(userId);
        }
    }

   

}

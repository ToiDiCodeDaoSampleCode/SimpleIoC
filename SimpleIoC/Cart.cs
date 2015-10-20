using SimpleIoC.Interface;

namespace SimpleIoC
{
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
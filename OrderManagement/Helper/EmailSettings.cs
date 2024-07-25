using System.Net.Mail;
using System.Net;
using Core.Entities.Order.Aggregate;

namespace OrderManagement.Helper
{
    public class EmailSettings
    {
        public static void SendEmail(string toEmail, string title, Order order)
        {
            var client = new SmtpClient("sandbox.smtp.mailtrap.io", 587);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("Mariam.sameh.duk@gmail.com", "xrhf gtoq actd bqyh");

            client.Send("Mariam.sameh.duk@gmail.com", toEmail, title, $"Your Order Status Has been Changed to {order.Status}");
        }
    }
}

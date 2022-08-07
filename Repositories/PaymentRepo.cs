using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using OnlineHotelManagementAPI.Models;

namespace OnlineHotelManagementAPI.Repositories
{
    public class PaymentRepo : IPayment
    {
        private HotelContext _context;

        public PaymentRepo(HotelContext context)
        {
            _context = context;
        }

        #region GetAllPayment
        public List<Payment> GetAllPayment()
        {
            try
            {
                List<Payment> payment = _context.Payments.ToList();
                return payment;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region InsertPayment
        public string InsertPayment(Payment payment)
        {
            string stcode = string.Empty;
            try
            {
                string s1 = payment.CardNumber;
                string s2 = "XXXX XXXX XXXX " + s1.Substring(12);
                payment.CardNumber = s2;
                _context.Payments.Add(payment);
                _context.SaveChanges();
                stcode = "200";
                SendEmail(payment);
            }
            catch (Exception e)
            {
                stcode = "400";
            }
            return stcode;
        }
        #endregion

        #region SavePayment
        public void SavePayment(Payment payment)
        {
            _context.SaveChanges();
        }
        #endregion

        #region UpdatePayment
        public string UpdatePayment(Payment payment)
        {
            string stcode = string.Empty;
            try
            {
                _context.Payments.Update(payment);
                _context.SaveChanges();
                stcode = "200";

            }
            catch (Exception e)
            {
                stcode = "400";
            }
            return stcode;
        }
        #endregion

        #region GetPaymentById
        public string GetPaymentById(int Id)
        {
            Payment payment;
            string stcode = string.Empty;
            try
            {
                payment = _context.Payments.Find(Id);
                if (payment != null)
                {
                    _context.SaveChanges();
                    stcode = "200";
                }
                else
                {
                    stcode = "400";
                }
            }
            catch (Exception e)
            {
                stcode = e.Message;
            }
            return stcode;

        }
        #endregion

        #region DeletePayment
        public string DeletePayment(int id)
        {
            string stcode = string.Empty;
            try
            {
                var payment = _context.Payments.Find(id);
                if (payment != null)
                {
                    _context.Payments.Remove(payment);
                    _context.SaveChanges();
                    stcode = "200";
                }
                else
                {
                    stcode = "400";
                }
            }
            catch
            {
                stcode = "400";
            }
            return stcode;
        }
        #endregion

        #region SendEmail
        public async Task<Payment> SendEmail(Payment payment)
        {
            try
            {
                var email = new MimeMessage();
                email.From.Add(MailboxAddress.Parse("EMAIL ID"));
                email.To.Add(MailboxAddress.Parse(payment.Email));
                email.Subject = "Payment Done";
                email.Body = new TextPart(MimeKit.Text.TextFormat.Html)
                {
                    Text = "Dear " + payment.CardholderName + ",<br>" +
                    "Welcome to our Hotel. Your payment was successful. Visit us again."+"<br>"+
                    "<pre>                                           Regards, Hotel.</pre>"
                };
                using var smtp = new SmtpClient();
                smtp.Connect("smtp.gmail.com",587,false);
                smtp.Authenticate("EMAIL ID", "PASSWORD");
                smtp.Send(email);
                smtp.Disconnect(true);
                return payment;

            }
            catch(Exception ex) 
            {
                string msg = "Error";
            }
            return payment;
        }
        #endregion
    }
}

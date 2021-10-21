using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace ApiSendEmail.Helpers
{
    public class SendEmail
    {
        public bool OneSendEmail(string _email, string _message, string _subject)
        {
            try
            {
                var fromAddress = new MailAddress("ryanapare321@gmail.com", "RianDev");
                var toAddress = new MailAddress(_email, "");
                string fromPassword = "Gdcr20200";
                string subject = _subject;
                string body = _message;

                var smtp = new SmtpClient
                {
                    
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
                    Timeout = 20000
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                 
                })
                {
                    message.IsBodyHtml = true;
                    smtp.Send(message);
                }
            
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

            return false;
        }
    }
}

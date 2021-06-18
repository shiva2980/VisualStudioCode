using NUnit.Framework;
using System;
using System.Net;
using System.Net.Mail;

namespace CSharpNUnitTesting
{
    [TestFixture]
    public class Mailing
    {
        [Test]
        public void MethodToSendEmail()
        {
           try
            {
                //Sender's email, password, to/receivers email, subject, body , attachment
                MailMessage mail = new MailMessage();
                string FromEmail = "vxkumarreddy@coopertire.com";
                string Password = "Cooper2021";
                string ToEmail = "vxkumarreddy@coopertire.com";
                string Subject = "Test Subject";
                string Body = "<h3> Test Mail From Selenium Tool</h3>";
                mail.From = new MailAddress(FromEmail);
                mail.To.Add(ToEmail);
                mail.Subject = Subject;
                mail.Body = Body;
                mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient("smtp.live.com", 587);
                smtp.Credentials = new NetworkCredential(FromEmail, Password);
                smtp.EnableSsl = true;
                smtp.Send(mail);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("inside finally");
            }
        }
    }
}

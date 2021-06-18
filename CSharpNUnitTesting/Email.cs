using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using NUnit.Framework;
using OpenQA.Selenium;


namespace CSharpNUnitTesting
{
   public class Email
   {
        string password = DecodedPassword("Q29vcGVyQDIwMjE=");
        public static string DecodedPassword(string password)
        {
            var encodepasswordinbytes = Convert.FromBase64String(password);
            string decodepassword = Encoding.UTF8.GetString(encodepasswordinbytes);
            return decodepassword;
        }
        [Test]
        public void EmailNotification()
        {
            try
            {

                // sender email, sender password, to receiver email, subject, body, cc, attachment
                MailMessage mail = new MailMessage();
                string FromEmail = "vxkumarreddy@coopertire.com";
                string Password = password;
                string ToEmail = "vxkumarreddy@coopertire.com";
                string Subject = "Github URL Testing";
                string ContentBody = "Github application has been tested successfully";
                mail.Attachments.Add(new Attachment(@"C:\Users\Admin\source\repos\CSharpNUnitTesting\CSharpNUnitTesting\ExtentReports\Github.html"));
                mail.From = new MailAddress(FromEmail);
                mail.To.Add(ToEmail);
                mail.Subject = Subject;
                mail.Body = ContentBody;
                mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient("smtp.live.com", 587);
                smtp.Credentials = new NetworkCredential(FromEmail, Password);
                smtp.EnableSsl = true;
                smtp.Send(mail);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            finally

            {
                Console.WriteLine("inside finally");
            }
        }
        [Test]

        public void TriggerEmail()
        {
            try
            {
                Assert.AreEqual(1, 2);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                SendEmailNow(e.Message.Trim(),e.StackTrace);
            }
            finally
            {

            }
        }

        public void SendEmailNow(string Subject, string ContentBody)
        {
            MailMessage mail = new MailMessage();
            string FromEmail = "vxkumarreddy@coopertire.com";
            string Password = password;
            string ToEmail = "vxkumarreddy@coopertire.com";
            mail.Attachments.Add(new Attachment(@"C:\Users\Admin\source\repos\CSharpNUnitTesting\CSharpNUnitTesting\ExtentReports\Github.html"));
            mail.From = new MailAddress(FromEmail);
            mail.To.Add(ToEmail);
            mail.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.live.com", 587);
            smtp.Credentials = new NetworkCredential(FromEmail, Password);
            smtp.EnableSsl = true;
            smtp.Send(mail);
        }
    }
}

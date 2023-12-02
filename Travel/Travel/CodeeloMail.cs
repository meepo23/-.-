using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Travel
{
     internal class CodeeloMail
    {
        public static MailMessage CreateMail(string name, string emailFrom, string emailTo, string subject, string body)
        {
            var from = new MailAddress(emailFrom, name);
            var to = new MailAddress(emailTo);
            var mail = new MailMessage(from, to);
            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = true;
            return mail;
        }
        public static void SendMail(string host, int smpPort, string emailFrom, string pass, MailMessage mail)
        {
            SmtpClient smtp = new SmtpClient(host, smpPort);
            smtp.Credentials = new NetworkCredential(emailFrom, pass);
            smtp.EnableSsl = true;
            smtp.Send(mail);
        }
    }
}
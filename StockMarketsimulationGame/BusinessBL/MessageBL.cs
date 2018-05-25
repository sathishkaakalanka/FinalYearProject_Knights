using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories;
using BusinessEntity;
using System.Net.Mail;
using System.Net;

namespace BusinessBL
{
    public class MessageBL
    {
        public static bool SendMail(string To, string subject, AlternateView emailBody)
        {
            var result = false;
            MailMessage mailMsg = new MailMessage();
            mailMsg.From = new MailAddress("stockmarketsimulationgame@gmail.com");
            string password = "D0Ggy123";
            mailMsg.Subject = subject;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            NetworkCredential NetworkCred = new NetworkCredential("stockmarketsimulationgame@gmail.com", password);
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = NetworkCred;
            smtp.Port = 587;

            mailMsg.To.Add(new MailAddress(To));

            mailMsg.IsBodyHtml = true;
            AlternateView htmlView = emailBody;
            mailMsg.AlternateViews.Add(htmlView);

            try
            {
                smtp.Send(mailMsg);
                result = true;
            }
            catch (SmtpException ex)
            {
                result = false;
                //throw ex;
            }
            return result;
        }

        public bool SendPassword(string DecordedPassword,string Email)
        {
            AlternateView htmlView = AlternateView.CreateAlternateViewFromString("<html xmlns=http://www.w3.org/1999/xhtml><head>" +
                  "<meta http-equiv=Content-Type content=text/html; charset=utf-8 />" +
                  "<title>Untitled Document</title>" +
                  "</head><body>" +
                  "<p align=left><strong style=font-family:Arial, Helvetica, sans-serif; font-weight:bold; font-size:20px;>" +
                  "Stock Market simulation Game Login Password is requested.</strong></p>" +
                  "<p align=left style=font-family: Georgia, 'Times New Roman', Times, serif; font-size:14px;>" +
                  "Your Password is " + DecordedPassword + " Play and enjoy the game." +
                  "<br />" +
                  "</p><p align=left style=font-family: Georgia, 'Times New Roman', Times, serif; font-size:14px;>" +
                  "Thank You,</p>" +
                  "</p><p align=left style=font-family: Georgia, 'Times New Roman', Times, serif; font-size:14px;>" +
                  "</p>" +
                  "</p><p align=left style=font-family: Georgia, 'Times New Roman', Times, serif; font-size:12px;>" +
                  "(Please do not reply to this email message)</p>"
                  , null, "text/html");
            return SendMail(Email, "Stock Market simulation Game Login Password", htmlView);
        }
    }
}

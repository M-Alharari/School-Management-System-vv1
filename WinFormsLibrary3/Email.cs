using System;
using System.Net;
using System.Net.Mail;

namespace SchoolProjectData
{
    public static class clsEmail
    {
        private static string _smtpServer = "smtp.gmail.com"; // Gmail SMTP
        private static int _smtpPort = 587; // TLS
        private static string _fromEmail = "yourgmail@gmail.com"; // replace with your email
        private static string _appPassword = "your-app-password"; // Gmail App Password

        /// <summary>
        /// Send a simple email.
        /// </summary>
        /// <param name="toEmail">Recipient email</param>
        /// <param name="subject">Email subject</param>
        /// <param name="body">Email body (plain text or HTML)</param>
        /// <param name="isHtml">True if body is HTML</param>
        /// <returns>True if sent successfully, otherwise false</returns>
        public static bool SendEmail(string toEmail, string subject, string body, bool isHtml = false)
        {
            try
            {
                using (SmtpClient client = new SmtpClient(_smtpServer, _smtpPort))
                {
                    client.Credentials = new NetworkCredential(_fromEmail, _appPassword);
                    client.EnableSsl = true;

                    using (MailMessage mail = new MailMessage(_fromEmail, toEmail, subject, body))
                    {
                        mail.IsBodyHtml = isHtml;
                        client.Send(mail);
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                // Log or show error
                Console.WriteLine("Email error: " + ex.Message);
                return false;
            }
        }
    }
}

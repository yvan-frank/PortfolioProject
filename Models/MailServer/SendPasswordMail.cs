using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
namespace Models.MailServer
{
    public abstract class SendPasswordMail
    {
        private SmtpClient _smtpClient;
        protected string SenderMail { get; set; }
        protected string Password { get; set; }
        protected string Host { get; set; }
        protected int Port { get; set; }
        protected bool Ssl { get; set; }

        protected void InitializedSmtp()
        {
            //_smtpClient = new SmtpClient();
            //_smtpClient.Credentials = new NetworkCredential(SenderMail, Password);
            //_smtpClient.Host = Host;
            //_smtpClient.Port = Port;
            //_smtpClient.EnableSsl = Ssl;

            _smtpClient = new SmtpClient()
            {
                Credentials = new NetworkCredential(SenderMail, Password), Host = Host, Port = Port, EnableSsl = Ssl
            };
        }

        public void SendMail(string subject, string body, List<string> recipientMail)
        {
            var mailMessage = new MailMessage();
            try
            {
                mailMessage.From = new MailAddress(SenderMail);
                foreach (string mails in recipientMail)
                {
                    mailMessage.To.Add(mails);
                }

                mailMessage.Subject = subject;
                mailMessage.Body = body;
                mailMessage.Priority = MailPriority.Normal;
                _smtpClient.Send(mailMessage);
            }
            catch
            {
                //Console.WriteLine();
            }
            finally
            {
                mailMessage.Dispose();
                _smtpClient.Dispose();
            }
        }
    }
}

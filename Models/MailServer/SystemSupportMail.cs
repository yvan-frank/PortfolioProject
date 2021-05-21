
namespace Models.MailServer
{
    public class SystemSupportMail:SendPasswordMail
    {
        public SystemSupportMail()
        {
            SenderMail = "zanghector5@gmail.com";
            Password = "durelle12";
            Host = "smtp.gmail.com";
            Port = 587;
            Ssl = true;
            InitializedSmtp();
        }
    }
}

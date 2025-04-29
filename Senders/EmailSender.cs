using System.Net;
using System.Net.Mail;

namespace WebUtils.Senders;

public class EmailSender
{
    public static void Send(string to, string subject, string body)
    {
        MailMessage mail = new()
        {
            From = new MailAddress("EMAIL", "DISPLAY Name"),
            Subject = subject,
            Body = body,
            IsBodyHtml = true
        };
        mail.To.Add(to);

        SmtpClient smtp = new("smtp.gmail.com", 587)
        {
            Credentials = new NetworkCredential("EMAIL", "PASSWORD"),
            EnableSsl = true
        };
        
        smtp.Send(mail);
    }
}

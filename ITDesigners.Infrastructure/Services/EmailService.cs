using ITDesigners.Application.Interfaces;
using ITDesigners.Models;
using System.Net.Mail;
using System.Threading;
using System.Threading.Tasks;

namespace ITDesigners.Infrastructure.Services
{
    public class EmailService : IEmailService
    {
        public EmailService()
        {

        }
        public Task SendAsync(Email email, CancellationToken cancellationToken)
        {
            MailMessage mailMessage = new MailMessage(email.EmailString, "davidokhromii@gmail.com" ,"New Massage", email.Message);
            SmtpClient smtpClient = new SmtpClient("localhost", 81);

            return smtpClient.SendMailAsync(mailMessage, cancellationToken);
        }
    }
}

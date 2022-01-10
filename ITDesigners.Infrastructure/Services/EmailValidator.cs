using ITDesigners.Application.Interfaces;

namespace ITDesigners.Infrastructure.Services
{
    public class EmailValidator : IEmailValidator
    {
        public bool Validate(string email)
        {
            if (email.Trim().EndsWith("."))
            {
                return false; 
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}

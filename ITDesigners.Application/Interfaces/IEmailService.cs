using ITDesigners.Models;
using System.Threading;

namespace ITDesigners.Application.Interfaces
{
    public interface IEmailService
    {
        void SendAsync(Email email, CancellationToken cancellationToken = default);
    }
}

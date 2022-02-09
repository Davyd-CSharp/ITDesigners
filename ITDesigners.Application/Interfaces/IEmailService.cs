using ITDesigners.Models;
using System.Threading;
using System.Threading.Tasks;

namespace ITDesigners.Application.Interfaces
{
    public interface IEmailService
    {
        Task SendAsync(Email email, CancellationToken cancellationToken = default);
    }
}

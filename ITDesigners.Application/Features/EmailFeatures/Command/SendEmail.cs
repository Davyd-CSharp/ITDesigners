using ITDesigners.Application.Interfaces;
using ITDesigners.Infrastructure;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ITDesigners.Application.Features.EmailFeatures.Command
{
    public static class SendEmail
    {
        public record Command(string EmailString, string Message) : IRequest;

        public class Handler : IRequestHandler<Command, Unit>
        {
            private readonly IEmailService _emailService;
            private readonly IEmailValidator _emailValidator;
            public Handler(IEmailService emailService, IEmailValidator emailValidator)
            {
                _emailService = emailService;
                _emailValidator = emailValidator;
            }
            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                if (!_emailValidator.Validate(request.EmailString)) 
                {
                    throw new EmailNotCorrectException("Email not correct");
                }

                _emailService.SendAsync(new Models.Email
                {
                    EmailString = request.EmailString,
                    Message = request.Message
                }, cancellationToken);

                return Unit.Value;
            }
        }
    }
}

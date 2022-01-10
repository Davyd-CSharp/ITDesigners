using ITDesigners.Application.Features.EmailFeatures.Command;
using ITDesigners.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace ITDesigners.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMediator _mediator;
        public HomeController(ILogger<HomeController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(Email email) 
        {
            await _mediator.Send(new SendEmail.Command(email.EmailString, email.Message));
            return StatusCode(200);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EksiCode.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthenticationController : ControllerBase
    {
        private readonly ILogger<AuthenticationController> _logger;
        public AuthenticationController(ILogger<AuthenticationController> logger)
        {
            _logger = logger;
        }
    }
}

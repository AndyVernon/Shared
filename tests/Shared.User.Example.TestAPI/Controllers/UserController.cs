using Microsoft.AspNetCore.Mvc;

namespace Shared.User.Example.TestAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        [Route("IsValidUsername")]
        public IActionResult IsValidUsername(string username)
        {
            return Ok();
        }
    }
}

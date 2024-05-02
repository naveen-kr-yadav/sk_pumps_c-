using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MotorizedMarvels.Services;
using System.Threading.Tasks;

namespace MotorizedMarvels.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginDetailsController : ControllerBase
    {
        private readonly ILogger<LoginDetailsController> _logger;
        private readonly ILoginService _loginService;

        public LoginDetailsController(ILogger<LoginDetailsController> logger, ILoginService loginService)
        {
            _logger = logger;
            _loginService = loginService;
        }

        [HttpGet]
        [Route("LoginDetails")]
        public async Task<IActionResult> GetLoginDetails()
        {
            try
            {
                var loginDetails = await _loginService.GetLoginDetails();
                if (loginDetails != null)
                {
                    return Ok(loginDetails);
                }
                else
                {
                    return NotFound("Login details not found.");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error.");
            }
        }
    }
}

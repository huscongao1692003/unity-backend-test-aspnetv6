using Microsoft.AspNetCore.Mvc;
using testloginunity.DTO;
using testloginunity.IService;
using System.Threading.Tasks;

namespace testloginunity.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _loginService;

        public LoginController(ILoginService login)
        {
            _loginService = login;
        }

        [HttpPost("user")] // Specify the HTTP method and route
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Login([FromBody] LoginDto dto)
        {
            string result = await _loginService.LoginService(dto);
            return Ok(result);
        }
    }
}

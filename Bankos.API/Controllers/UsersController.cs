using Bankos.Services.BusinessLogic.BasicServices.UserServices;
using Bankos.Services.DTOs.UserDTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bankos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserServices userServices;

        public UsersController(IUserServices userServices)
        {
            this.userServices = userServices;
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterUser(UserRegisterDTO newUser)
        {
            var result = await userServices.RegisterUser(newUser);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("login")]
        public async Task<IActionResult> LoginUser(UserLoginDTO user)
        {
            var result = await userServices.LoginUser(user);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}

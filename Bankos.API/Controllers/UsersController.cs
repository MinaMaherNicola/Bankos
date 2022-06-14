using Bankos.Services.DTOs.Users.AuthDTOs;
using Bankos.Services.Services.UserServices;
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

        [HttpPost("Users")]
        public async Task<IActionResult> RegisterUser(RegisterDTO newUser)
        {
            var response = await userServices.RegisterNewUser(newUser);

            return Ok(response);
        }
    }
}

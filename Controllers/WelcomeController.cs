using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using WebApi.Services;
using WebApi.Entities;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class WelcomeController : ControllerBase
    {
        private IUserService _userService;

        public WelcomeController(IUserService userService)
        {
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpGet()]
        public IActionResult WelcomeUser()
        {
            return Ok("Hi. You are welcome!!");
        }
    }
}

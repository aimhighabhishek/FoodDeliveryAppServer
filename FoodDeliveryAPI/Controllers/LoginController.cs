using FoodDeliveryAPI.Models;
using FoodDeliveryAPI.UserRegisterRepo;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FoodDeliveryAPI.Controllers
{
    [ApiController]
    [Route("foodDelievryapi/authorize")]
    [EnableCors("AllowReactApp")]
    public class LoginController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public LoginController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserRegistration users)
        {
            if (users == null || string.IsNullOrEmpty(users.Email) || string.IsNullOrEmpty(users.Password))
            {
                return BadRequest("Invalid user data");
            }

            var user = await _userRepository.Login(users);

            if (user == null)
            {
                return NotFound(new { message = "User not found" });
            }

            return Ok(new { message = "Login successful", user });
        }
    }
}

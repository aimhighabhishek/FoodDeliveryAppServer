using FoodDeliveryAPI.Models;
using FoodDeliveryAPI.UserRegisterRepo;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace FoodDeliveryAPI.Controllers
{
    [ApiController]
    [Route("foodDelievryapi/user")]
    [EnableCors("AllowReactApp")]
    public class UserRegisterController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public UserRegisterController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterUser([FromBody] UserRegistration userRegistration)
        {
            UserRegistration user = new UserRegistration
            {
                Name = userRegistration.Name,
                Address = userRegistration.Address,
                Password = userRegistration.Password,
                Email = userRegistration.Email,
                UserRole = "user",
                PhoneNumber = userRegistration.PhoneNumber
            };
            var registeredUser = await _userRepository.RegisterUser(user);
            return Ok(registeredUser);
        }

    }
}

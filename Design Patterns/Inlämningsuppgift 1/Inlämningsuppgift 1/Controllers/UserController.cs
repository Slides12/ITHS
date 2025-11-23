using Inlämningsuppgift_1.Interfaces;
using Inlämningsuppgift_1.Services;
using Microsoft.AspNetCore.Mvc;
using static Inlämningsuppgift_1.Services.UserService;

namespace Inlämningsuppgift_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class UserController : ControllerBase
    {
        //1
        private readonly IUserService _userService; /*= new UserService();*/

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        //2
        //public class LoginRequest { public string Username { get; set; } = ""; public string Password { get; set; } = ""; }
        //public class RegisterRequest { public string Username { get; set; } = ""; public string Password { get; set; } = ""; public string Email { get; set; } = ""; }

        [HttpPost("register")]
        public IActionResult Register([FromBody] RegisterRequest req)
        {
            //if (string.IsNullOrWhiteSpace(req.Username) || string.IsNullOrWhiteSpace(req.Password))
            //    return BadRequest("Username and password required.");
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var created = _userService.Register(req.Username, req.Password, req.Email);
            if (!created) return Conflict("User already exists.");

            return Ok(new { Message = "Registered" });
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest req)
        {
            //if (string.IsNullOrWhiteSpace(req.Username) || string.IsNullOrWhiteSpace(req.Password))
            //    return BadRequest("Missing credentials.");
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var token = _userService.Login(req.Username, req.Password);
            if (token == null) return Unauthorized("Invalid credentials.");
                       
            return Ok(new { Token = token });
        }

        [HttpGet("profile")]
        public IActionResult Profile([FromHeader(Name = "X-Auth-Token")] string token)
        {
            
            if (string.IsNullOrWhiteSpace(token)) return Unauthorized();

            var profile = _userService.GetUserByToken(token);
            if (profile == null) return Unauthorized();

            return Ok(new { profile.Username, profile.Email, profile.Id });
        }
    }
}

using System.ComponentModel.DataAnnotations;

namespace Inlämningsuppgift_1.Controllers
{
    public class LoginRequest 
    {
        [Required]
        public string Username { get; set; } = "";
        [Required]
        public string Password { get; set; } = ""; 
    }
}

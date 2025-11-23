using System.ComponentModel.DataAnnotations;

namespace Inlämningsuppgift_1.Controllers
{
    public class RegisterRequest 
    {
        [Required]
        public string Username { get; set; } = "";
        [Required]
        public string Password { get; set; } = "";
        [EmailAddress]
        public string Email { get; set; } = ""; 
    }
}

using System.ComponentModel.DataAnnotations;

namespace BlazorAppDemo.Entities
{
    public class PersonInfoEntity
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Namn är obligatoriskt.")]
        public required string Name { get; set; }
        [Required(ErrorMessage = "Email är ett måste.")]
        [EmailAddress(ErrorMessage = "Ogiltig email-adress.")]
        public required string Email { get; set; }
        [Range(1, 100, ErrorMessage = "Ålder måste ligga mellan 1-100.")]
        public int Age { get; set; }
    }
}

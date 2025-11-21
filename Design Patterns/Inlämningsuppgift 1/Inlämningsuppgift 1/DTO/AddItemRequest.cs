using System.ComponentModel.DataAnnotations;

namespace Inlämningsuppgift_1.Controllers
{
    public class AddItemRequest
    {
        [Required]
        public int ProductId { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be > 0")]
        public int Quantity { get; set; }
    }
}

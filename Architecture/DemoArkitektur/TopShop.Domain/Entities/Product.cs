using System.ComponentModel.DataAnnotations;

namespace TopShop.Domain.Entities
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [StringLength(40)]
        public string ProductName { get; set; }
    }
}

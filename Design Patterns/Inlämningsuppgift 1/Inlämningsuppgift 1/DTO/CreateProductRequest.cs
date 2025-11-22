namespace Inlämningsuppgift_1.Controllers
{
    public class CreateProductRequest
    {
        public string Name { get; set; } = "";
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}

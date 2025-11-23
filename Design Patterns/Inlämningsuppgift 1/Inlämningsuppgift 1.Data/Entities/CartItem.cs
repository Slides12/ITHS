namespace Inlämningsuppgift_1.Entities
{
    public class CartItem
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public string ProductName { get; set; }
    }
}

namespace DesignPattern.Data.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }

        public Product(int productID, string name)
        {
            ProductID = productID;
            Name = name;
        }
    }
}

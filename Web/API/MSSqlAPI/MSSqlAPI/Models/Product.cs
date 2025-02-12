namespace MSSqlAPI.Models;

public class Product
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public string? ProductCategory { get; set; }
    public bool Status { get; set; }
}

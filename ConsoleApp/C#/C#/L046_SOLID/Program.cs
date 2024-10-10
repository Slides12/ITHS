//var dbReader = new ShoppingCart(new DataBaseReader("192.168.0.1", "Everyloop"));
var fileReader = new FileReader("products.txt");
ShoppingCart cart = new ShoppingCart(fileReader);

cart.LoadProducts();
cart.ShowProducts();

Console.WriteLine();

var dbReader = new DataBaseReader("192.168.0.1", "Everyloop");
ShoppingCart cart2 = new ShoppingCart(dbReader);
cart2.LoadProducts();
cart2.ShowProducts();

class Product
{
    public string Name { get; set; }
    public Product(string name)
    {
        this.Name = name;
    }

}
class ShoppingCart
{

    private List<Product> products;
 
    private IReader reader;


    public ShoppingCart(IReader reader)
    {
        this.reader = reader;   
    }

    
    public void ShowProducts()
    {
        products.ForEach(p => Console.WriteLine(p.Name));
    }
    public void LoadProducts()
    {
        //var reader = new DataBaseReader(); // new is glue.
        products =  reader.LoadProducts();
    }

}


class DataBaseReader : IReader
{

    private string serverName;
    private string databaseName;

    public DataBaseReader(string serverName, string databaseName)
    {
        this.serverName = serverName;
        this.databaseName = databaseName;
    }

    public List<Product> LoadProducts()
    {
        Console.WriteLine($"Loading products from database {databaseName} on server {serverName}");

        var products = new List<Product>();
        // Code that reads procuts from a database.
        products.Add(new Product("database product A"));
        products.Add(new Product("database product B"));

        return products;

    }
}



class FileReader : IReader
{
    private string filePath;

    public FileReader(string filePath)
    {
        this.filePath = filePath;
    }

    public List<Product> LoadProducts()
    {
        Console.WriteLine($"Loading products from {filePath}!");

        var products = new List<Product>();


        // Code that reads procuts from a database.
        products.Add(new Product("file product A"));
        products.Add(new Product("file product B"));
        products.Add(new Product("file product C"));


        return products;

    }
}


interface IReader
{
    public List<Product> LoadProducts();
}
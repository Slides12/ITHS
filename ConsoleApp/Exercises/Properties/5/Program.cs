
Car car = new Car("Mercedes", 30000, "Red");

Console.WriteLine($"Model: {car.Model}, Color: {car.Color}, Price: {car.Price}");
car.HalfPrice();
Console.WriteLine($"Model: {car.Model}, Color: {car.Color}, Price: {car.Price}");


car.Color = "Green";
car.Model = "Saab";
car.Price = 20000;

Console.WriteLine($"Model: {car.Model}, Color: {car.Color}, Price: {car.Price}");
car.HalfPrice();
Console.WriteLine($"Model: {car.Model}, Color: {car.Color}, Price: {car.Price}");



class Car
{
    private string _model;
    private int _price;
    private string _color;


    public string Model
    {
        get { return _model; }
        set { _model = value; }
    }

    public int Price
    {
        get { return _price; }
        set { _price = value; }

    }

    public string Color
    {
        get { return _color; }
        set { _color = value; }
    }


    private Car()
    {

    }

    public Car(string model, int price, string color)
    {
        _model = model;
        _price = price;
        _color = color;
    }


    public void HalfPrice()
    {
        _price /=2;
    }


}
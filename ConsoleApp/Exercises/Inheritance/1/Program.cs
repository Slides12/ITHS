Console.WriteLine();

enum Brand
{
    Volvo,
    Mercedes,
    Saab,
    Toyota,
    Wolkswagen
}


enum Color
{
    Green,
    Black,
    White,
    Gray,
    Brown
}


class Vehicle
{
    public Brand Brand  { get; set; }
    public Color Color { get; set; }

    public Vehicle(Brand brand, Color color) :this(brand)
    {
        this.Color = color;
    }
    public Vehicle(Brand brand)
    {
        this.Brand = brand;
        this.Color = Color.Black;
    }

}
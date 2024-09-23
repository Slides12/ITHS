

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

    public Vehicle(Brand brand, Color color) 
    {
        this.Color = color;
        this.Brand = brand;
    }
    public Vehicle(Brand brand)
    {
        this.Brand = brand;
        this.Color = Color.Black;
    }

}
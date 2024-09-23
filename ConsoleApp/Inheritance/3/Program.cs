Console.WriteLine(new Car(Brand.Toyota, "Yaris", Color.White));


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
    public Brand Brand { get; set; }
    public Color Color { get; set; }

    public Vehicle(Brand brand, Color color) : this(brand)
    {
        this.Color = color;
    }
    public Vehicle(Brand brand)
    {
        this.Brand = brand;
        this.Color = Color.Black;
    }

    public Vehicle()
    {

    }

    public override string ToString()
    {
        return $"A {this.Color} {this.Brand}";
    }
}


class Car : Vehicle
{
    public string Model { get; set; }



    public Car(Brand brand, string model, Color color) : base(brand, color)
    {
        
        this.Model = model;
    }
    public override string ToString()
    {
        return $"A {this.Color} {this.Model} from {this.Brand}";
    }

}
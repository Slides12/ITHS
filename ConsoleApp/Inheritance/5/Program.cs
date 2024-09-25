using System.ComponentModel.DataAnnotations;
using System.Drawing;

Console.WriteLine(new Car(Brand.Toyota, "Yaris", Color.White));



struct Size
{
    public double Length { get; set; }
    public double Height { get; set; }
    public double Width { get; set; }


    public Size(double length, double height, double width)
    {
        this.Length = length;
        this.Height = height;
        this.Width = width;
    }
}




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
    public Random rand;
    public Size Size { get; set; }

    public Vehicle(Brand brand, Color color) : this(brand)
    {
        this.Color = color;
    }
    public Vehicle(Brand brand) : this()
    {
        this.Brand = brand;
        this.Color = Color.Black;
    }


    //RandomDoulbe * Range + offset
    public Vehicle()
    {
       rand = new Random();
       //Size = new Size() { Length = rand.NextDouble() + 2, Height = rand.NextDouble() +1, Width = rand.NextDouble() + 1 };
       Size = new Size() { Length = rand.NextDouble() * 2 + 2, Height = rand.NextDouble() * 2 + 2, Width = rand.NextDouble() * 2 + 1 };

    }

    public override string ToString()
    {
        return $"A  {this.Color} {this.Brand}";
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
        return $"A {this.Color} {this.Size.Length:f2} meter {this.Model} from {this.Brand}";
    }

}

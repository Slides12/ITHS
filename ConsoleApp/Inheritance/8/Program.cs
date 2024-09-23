using System.Drawing;

var square = new Square(3.2);
square.Print();

var circle = new Circle(4.5);
circle.Print();


public abstract class Shape
{
    public abstract double Area { get; }
    public abstract double Circumference { get; }

    public abstract void Print();
}



class Circle : Shape
{
    public override double Area { get; }

    public override double Circumference { get; }

    public double radius;
    public Circle(double radius)
    {
        this.radius = radius;
        this.Area = radius * radius * Math.PI;
        this.Circumference = 2 * radius * Math.PI;
    }

    public override string ToString()
    {

        return $"A circle with the radius {this.radius}";
    }

    public override void Print()
    {
        Console.WriteLine($"A circle with radius {radius:f1} has an area of {Area:f2} and a circumference of {Circumference:f2}.");

    }
}



class Square : Shape
{
    public override double Area { get; }
    public double side;
    public override double Circumference { get; }

    public Square(double side)
    {
        this.side = side;
        this.Area = side * side;
        this.Circumference = 4 * side;
    }

    public override string ToString()
    {

        return $"A square with the radius {this.side}";
    }

    public override void Print()
    {
        Console.WriteLine($"A square with side {side:f1} has an area of {Area:f2} and a circumference of {Circumference:f2}.");
    }
}
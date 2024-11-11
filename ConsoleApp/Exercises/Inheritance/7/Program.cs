var square = new Square(5);
Console.WriteLine(square);
Console.WriteLine($"Area: {square.Area:f2}");
Console.WriteLine($"Circumference: {square.Circumference:f2}");


public abstract class Shape
{
    public abstract double Area { get; }
    public abstract double Circumference { get; }
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
}
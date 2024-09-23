var circle = new Circle(5);
Console.WriteLine(circle);
Console.WriteLine($"Area: {circle.Area:f2}");
Console.WriteLine($"Circumference: {circle.Circumference:f2}");




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
        this.Area = radius*radius* Math.PI;
        this.Circumference = 2 * radius * Math.PI;
    }

    public override string ToString()
    {

        return $"A circle with the radius {this.radius}";
    }
}

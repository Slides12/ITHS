namespace _11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Shape[] shapes = new Shape[10];

            for (int i = 0; i < shapes.Length; i++)
            {
                if (rnd.Next(1, 3) == 1)
                {
                    shapes[i] = new Square(rnd.Next(1, 10));

                }
                else
                {
                    shapes[i] = new Circle(rnd.Next(1, 10));

                }
            }
            Shape.PrintAll(shapes);
            Console.WriteLine();
            Shape.PrintCircles(shapes);
        }
    }
}

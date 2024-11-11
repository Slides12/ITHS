Car car = new Car();

Car[] cars = new Car[1000];

for (int i = 0;i < 1000; i++)
{
    Car cc = new Car();
    cars[i] = cc;
}


Console.WriteLine($"The total length of the green cars are {ReturnGreenCarLength(cars)} meters.");



static int ReturnGreenCarLength(Car[] cars)
{
    int totalGreenLenght = 0;
    int totalAllLenght = 0;

    foreach (Car car in cars)
    {
        totalAllLenght += car._length;
        if (car._color == ConsoleColor.Green)
        {
            totalGreenLenght += car._length;
        }
    }
    Console.WriteLine($"The total length of all cars are: {totalAllLenght}. \n");
    return totalGreenLenght;
}


class Car
{

    public ConsoleColor _color;
    public int _length;

    Random rnd = new Random();
    ConsoleColor[] colorArray = new ConsoleColor[] {ConsoleColor.White,ConsoleColor.Green,ConsoleColor.Red,ConsoleColor.Blue,ConsoleColor.Gray };


    public Car()
    {
        this._length = rnd.Next(3,5);
        this._color = colorArray[rnd.Next(colorArray.Length)];



        Console.ForegroundColor =  _color;
        Console.WriteLine($"This car is {_length} meters and the color is the same as this text.");
        Console.ForegroundColor = ConsoleColor.White;

    }


}
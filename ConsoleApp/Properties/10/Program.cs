using System.Drawing;

Car[] cars = new Car[10];
int maxDistance = 10000;
bool finished = false;

for (int i = 0; i< cars.Length; i++) { 
    Car car = new Car() {name =$"Car {i+1}" };
    cars[i] = car;
}



while (!finished) 
{
    int index = PrintCarDistance();

    if (finished)
    {
        Console.WriteLine();
        Console.WriteLine($"{cars[index].name} was the fastest to travel 1000 mil! ");
        Console.ForegroundColor = cars[index]._color;
        Console.WriteLine($"Lucky color {cars[index]._color}!");
        Console.ForegroundColor = ConsoleColor.White;


    }
}



int PrintCarDistance()
{
    Thread.Sleep(500);
    Console.Clear();
    int index = 0;
    for (int j = 0; j < cars.Length; j++)
    {
        cars[j].DriveForOneHour();
        Console.Write($"{cars[j].name}: ".PadRight(8));
        //Console.Write(cars[j].GetGraph());
        PrintXInColor(cars[j]);
        Console.Write($"{cars[j].Distance} kilometer".PadLeft(8));
        Console.WriteLine();
        if (cars[j]._distance >= maxDistance)
        {
            index = j;
            finished = true;
        }
    }
    return index;
}


void PrintXInColor(Car cars)
{
    foreach(char c in cars.GetGraph())
    {
        if(c == 'X') {
            Console.ForegroundColor = cars._color;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
        Console.Write(c);
    }
}



class Car
{

    public ConsoleColor _color;
    public int _length;
    public int _speed;
    public int _distance = 0;
    public string name = "Car";



    public int Distance { get { return _distance; } set { this._distance = value; } }
    
    Random rnd = new Random();
    ConsoleColor[] colorArray = new ConsoleColor[] { ConsoleColor.White, ConsoleColor.Green, ConsoleColor.Red, ConsoleColor.Blue, ConsoleColor.Yellow, ConsoleColor.Cyan };


    public Car()
    {
        this._length = rnd.Next(3, 5);
        this._color = colorArray[rnd.Next(colorArray.Length)];
        this._speed = rnd.Next(60,240);


        Console.ForegroundColor = _color;
        //Console.WriteLine($"This car is {_length} meters and the color is the same as this text.");
        Console.ForegroundColor = ConsoleColor.White;

    }

    public static Car[] Return10CarsSameColor(Car car)
    {
        Car[] cars1 = new Car[10];

        for (int i = 0; i < cars1.Length; i++)
        {
            Car car1 = new Car();
            car1._color = car._color;
            cars1[i] = car1;
        }

        return cars1;
    }


    public void DriveForOneHour()
    {
        this._distance += this._speed;
    }


    public string GetGraph()
    {
        string drivingDistance = "";

        for (int i = 0;i <= 20; i++)
        {
            if(i == 0)
            {

                drivingDistance += string.Join("", "|");



            }
            else if (i == 20)
            {
                drivingDistance += string.Join("", "|");

            }
            else if(this._distance/500 == i)
            {

                drivingDistance += string.Join("", "X");

            }
            else 
            {
                drivingDistance += string.Join("", "-");
            }

        }
        return drivingDistance;

    }


}
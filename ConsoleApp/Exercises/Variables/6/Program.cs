string userInput1 = "";
string userInput2 = "";

string addSubDivTim;
int x;
int y;


while (true)
{
    Console.WriteLine("Mata in första talet.");
    userInput1 = Console.ReadLine(); 

    if(int.TryParse(userInput1, out x))
    {
        x = int.Parse(userInput1);
    }
    else
    {
        Console.WriteLine("Not a number. Try again\n");
        continue;
    }

    Console.WriteLine("Välj +, -, /, *.");
    addSubDivTim = Console.ReadLine();
    Console.WriteLine(addSubDivTim);

    


    Console.WriteLine("Mata in andra talet.");
    userInput2 = Console.ReadLine();


    if (int.TryParse(userInput2, out y))
    {
        y = int.Parse(userInput2);
    }
    else
    {
        Console.WriteLine("Not a number. Try again\n");
        continue;
    }



    switch (addSubDivTim)
    {
        case "+":
            Console.WriteLine($"{x} {addSubDivTim} {y } = {x+y}");
            break;

        case "-":
            Console.WriteLine($"{x} {addSubDivTim} {y} = {x - y}");

            break;

        case "/":
            Console.WriteLine($"{x} {addSubDivTim} {y} = {x / y}");

            break;

        case "*":
            Console.WriteLine($"{x} {addSubDivTim} {y} = {x * y}");

            break;

        default:
            Console.WriteLine("Mest troligtvis använda du inte +, -, /, *. Testa igen.\n");
            break;
    }
}
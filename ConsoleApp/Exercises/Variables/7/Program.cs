int x;
int count = 0;
int sum = 0;
string userInput;

while (true)
{
    Console.WriteLine("Skriv ett tal: ");
    userInput = Console.ReadLine();


    if(int.TryParse(userInput, out x))
    {
        count++;
        sum += x;

    }
    else if(userInput == "")
    {
        Console.WriteLine((double)sum / (double)count);

        break;
    }
    else
    {
        Console.WriteLine("Inte ett tal. Testa igen. \n");
        continue;
    }


    Console.WriteLine(sum);

}

Console.WriteLine("vad vill du räkna ut?");

string userInput = Console.ReadLine();
string[] userInputArray = userInput.Split(' ');

int[] numbers = new int[2];
string SubDivPlusTimes = "";

foreach (string c in userInputArray)
{
    if (int.TryParse(c.ToString(), out int y)){
        if (numbers[0] == 0) { 
        numbers[0] = (y);
        }
        else
        {
            numbers[1] = (y);
        }
    }
    else
    {
        if (c == "*")
        {
            SubDivPlusTimes = c;
        }
        else if (c == "+")
        {
            SubDivPlusTimes = c;

        }
        else if (c== "-")
        {
            SubDivPlusTimes = c;

        }
        else if(c == "/")
        {
            SubDivPlusTimes = c;

        }
    }
}

if(SubDivPlusTimes == "*")
{
    Console.WriteLine(numbers[0] * numbers[1]);
}
else if (SubDivPlusTimes == "+")
{
    Console.WriteLine(numbers[0] + numbers[1]);
}
else if (SubDivPlusTimes == "-")
{
    Console.WriteLine(numbers[0] - numbers[1]);
}
else if (SubDivPlusTimes == "/")
{
    Console.WriteLine(numbers[0] / numbers[1]);
}

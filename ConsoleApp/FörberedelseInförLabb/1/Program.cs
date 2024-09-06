string userInput = "Hello world!";

foreach(Char c in userInput)
{
    if (c == ' ')
    {
        break;
    }
    else
    {
        Console.Write(c);
    }

}
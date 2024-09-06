string userInput = "This is just some other text";

foreach (Char c in userInput)
{
    if(c ==  ' ')
    {
        Console.WriteLine();
    }
    else
    {
        Console.Write(c);
    }
}
string myString = "Hello world";

Console.WriteLine(myString.Length);


for (int i = 0; i < myString.Length; i++)
{
    Console.WriteLine(myString[i]);
}

foreach (char letter in myString)
{
    Console.WriteLine(letter);
}


char myChar = 'g';

Console.WriteLine();

Console.WriteLine("Hello \\world! ");
Console.WriteLine($"Hello {77*2} world! ");
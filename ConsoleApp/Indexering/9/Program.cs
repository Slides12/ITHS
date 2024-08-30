string hw = "Hello World!";
char[] gw= hw.ToCharArray();



for (int i = 0; i < hw.Length; i++)
{
    Console.WriteLine();
    for (int j = 0; j < i; j++)
    {
        Console.Write(gw[j]);
    }
}
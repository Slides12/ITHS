using System.Collections;


foreach(var item in GetNumber())
{
    Console.WriteLine(item);
}


IEnumerable GetNumber()
{
    for(int i = 0; i < 10;i++)
    {
        yield return i;
    }
}
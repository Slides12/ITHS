int x = 0;
for(int i = 99; i > 0; i--)
{
    x = i * i;
    if(int.Parse(Reverse(x.ToString())) == x)
    {
        Console.WriteLine($"{i*i}");
        break;
    }

}


static string Reverse(string text)
{
    if (text == null) return null;
    char[] array = text.ToCharArray();
    Array.Reverse(array);
    return new String(array);
}
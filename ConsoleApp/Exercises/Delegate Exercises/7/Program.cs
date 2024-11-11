string[] newStringArray = new string[] {"Göteborg", "Stockholm", "Malmö", "Jönköping", "Umeå" };


IngenAning(newStringArray, s => s.ToUpper());
IngenAning(newStringArray, s => s.Substring(0,3));
IngenAning(newStringArray, s => s.Length.ToString());



void IngenAning(string[] array, Func<string, string> modifier)
{
    foreach (var s in array)
    {
        Console.WriteLine(modifier.Invoke(s));
    }
}
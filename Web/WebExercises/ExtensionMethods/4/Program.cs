

class Program
{
    static void Main()
    {
        string text = "daniel";

        Console.WriteLine(text.Capitalize());
    }
}


public static class CapitalizeFirst
{
    public static string Capitalize(this string text){
        string cap = "";
        for(int i = 0; i < text.Length; i++)
        {
            if(i == 0){
                cap += text.ToUpper()[i];
                continue;
            }
            cap += text[i];
        }
        return cap;
    }
}

List<string> strings = new List<string>(){
    "hej",
    "På",
    "dIg",
    "dU",
    "HuR",
    "mÅR",
    "Du",
    null
};


var list = strings.GörVersaler();

foreach(var item in list)
{
    System.Console.WriteLine(item);
}


public static class Versaler
{
    public static List<string> GörVersaler(this List<string> list)
    {
        List<string> newList = list.Where(i => i != null)
                           .Select(i => i.ToString().ToUpper())
                           .ToList();

        return newList;
    }
}
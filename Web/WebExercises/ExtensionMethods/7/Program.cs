
List<string> list = new List<string>()
{
    "hej",
    "på",
    "dig",
    "du",
    "hur",
    "mår",
    "du",
    "idag"
};

System.Console.WriteLine(list.RandomElement());

public static class RandomEle
{
    public static T RandomElement<T>(this List<T> list)
    {
        Random rnd = new Random();
        var index = rnd.Next(0, list.Count());
        return list[index];
    }
}


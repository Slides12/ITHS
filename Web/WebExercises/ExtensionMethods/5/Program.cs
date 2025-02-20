

class Program
{
    static void Main()
    {
        List<int> list = new List<int>(){
            1,
            31,
            44,
            62,
            37
        };

        var newList = list.FilterByPredicate(n => n > 10);


        foreach(int num in newList)
        {
            System.Console.WriteLine(num);
        }

    }
}



public static class PredicateFilter
{
    public static List<T> FilterByPredicate<T>(this List<T> list, Func<T,bool> predicate)
    {
        if(list is null)
        {
            return null;
        }

        var result = new List<T>();
        foreach(T num in list)
        {
            if(predicate(num))
            {
                result.Add(num);
            }
        }
        return result;
    }
}
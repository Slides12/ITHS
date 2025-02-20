

List<int> ints = new List<int>() {
    1,
    1,
    1,
    2,
    2,
    32,
    23,
    52,
    52
};

var newList = ints.RemoveDuplicates();

foreach(var item in newList){
    System.Console.WriteLine(item);
}

public static class RemoveDupes
{
    public static List<T> RemoveDuplicates<T>(this List<T> list)
    {
            return list.Distinct().ToList();
    }
}
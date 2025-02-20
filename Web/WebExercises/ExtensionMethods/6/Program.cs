
List<int> list1 = new List<int>() {
    1,
    2,
    32,
    53,
    82
};


List<int> list2 = new List<int>() {
    31,
    23,
    52,
    25,
    16
};

List<int> list3 = new List<int>() {
    312,
    233,
    52,
    254,
    165
};

var newList = list1.MergeLists(list2,list3);

foreach(var item in newList)
{
    System.Console.WriteLine(item);
}

public static class MergeList
{
  public static List<T> MergeLists<T>(this List<T> firstList, params List<T>[] otherLists)
{
    var newList = new List<T>(firstList);

    foreach (var list in otherLists)
    {
        newList.AddRange(list);
    }

    return newList;
}
}


List<int> ints = new List<int>()
{
    1,
    2,
    4,
    5,
    86,
    77,
    475,
    54,
    99
};

var grouped = ints.GupperaEfterPredicate(n => n % 2 == 0);

 foreach (var group in grouped)
        {
            string key = group.Key ? "Jämna tal" : "Udda tal";
            Console.WriteLine($"{key}: {string.Join(", ", group)}");
        }


public static class GroupClause
{
    public static IEnumerable<IGrouping<bool, T>> GupperaEfterPredicate<T>(this List<T> list, Func<T,bool> predicate)
    {
        return list.GroupBy(predicate);
    }
}
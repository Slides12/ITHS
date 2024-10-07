////Linq

//var list = Enumerable
//    .Range(0, 10)
//    .Select(i => CostlyOperation(i))
//    .ToList();
//Console.WriteLine("\nProcessing completer! Here is the processed data:\n");
//list.ForEach(i => Console.WriteLine(i));


//static int CostlyOperation(int n)
//{
//    Thread.Sleep(1000);
//    Console.WriteLine($"Processing element: {n}");
//    return n;
//}


// Plinq

var list1 = Enumerable
    .Range(0, 50)
    .AsParallel() // Bara denna biten av kod skiljer från ovan
    .Select(i => CostlyOperation1(i))
    .ToList();
Console.WriteLine("\nProcessing completer! Here is the processed data:\n");
list1.ForEach(i => Console.WriteLine(i));


static int CostlyOperation1(int n)
{
    for (int i = 0; i < 1000_000_000; i++) ;
    
    Console.WriteLine($"Processing element: {n}");
    return n;
}
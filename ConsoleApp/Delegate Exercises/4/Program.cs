
Action<int, int> myDelegate = (x, y) => Console.WriteLine(x+y);


myDelegate.Invoke(5, 5);

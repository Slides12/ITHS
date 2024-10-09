

using System.Diagnostics.Metrics;
object lockA = new object();
object lockB = new object();

int counter = 0;
var task1 = Task.Run(() => 
{
    for (int i = 0; i < 1000; i++)
    {
        lock (lockA) 
        {
            lock (lockB)
            {
                counter++;
                Console.WriteLine(counter);
            }
        }
    }
});

var task2 = Task.Run(() =>
{
    for (int i = 0; i < 1000; i++)
    {
        lock (lockB)
        {
            lock (lockA)
            {
                counter++;
                Console.WriteLine(counter);
            }
        }
    }
});

Task.WaitAll(task1,task2);
Console.WriteLine(counter);
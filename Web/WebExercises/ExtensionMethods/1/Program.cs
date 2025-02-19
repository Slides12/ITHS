using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> list = new List<int>() { 32, 64, 77, 99 };
        int sum = list.GetSumFromList(); 
        int avg = list.GetAverageFromList(); 

        Console.WriteLine($"Sum: {sum}, Average: {avg}"); 
    }
}

public static class ExtensionMethods
{
    public static int GetSumFromList(this List<int> list)
    {
        int count = 0;
        foreach (int value in list)
        {
            count += value;
        }
        return count;
    }

    public static int GetAverageFromList(this List<int> list)
    {
        int count = 0;
        foreach (int value in list)
        {
            count += value;
        }

        return count / list.Count();
    }
}

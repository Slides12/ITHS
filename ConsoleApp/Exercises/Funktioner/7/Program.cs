static double Average(int[] numbers)
{
    int sum = 0;

    for (int i = 0;i < numbers.Length; i++)
    {
        sum += numbers[i];
    }

    return sum / numbers.Length;
}

Console.WriteLine(Average(new int[] {1,2,3,4,5,6,7}));
﻿int totalSum = 0;
for(int i = 0; i < 1000; i++)
{
    if(i % 3 == 0 || i % 5 == 0)
    {
        totalSum += i;
    }
}

Console.WriteLine(totalSum);
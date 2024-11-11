long x = 0;
long y = 0;
long z = 1;

long totalSum = 0;

for (int i = 0; i < 80; i++)
{
    if(i % 2 == 0)
    {
        x = z;
    }
    else
    {
        y = z;
    }

    z = x + y;

    if(z % 2 == 0 && z < 4000000)
    {
        totalSum+= z;
        Console.WriteLine(totalSum);

    }

}
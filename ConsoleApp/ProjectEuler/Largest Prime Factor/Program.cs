long number = 600851475143;
int factor = 3;

for (long i = 2; i <= number; i++)
{
    if (number % factor == 0)
    {
        number /= factor;
    }
    else{
        factor += 2;
    }
    
}
Console.WriteLine(factor);
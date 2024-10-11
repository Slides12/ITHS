int[] ints = new int[] {1,2,-3,14,13,-45,59,100,-21,37};


Uppgift8(ints, x => x < 0);
Uppgift8(ints, x => x <= 20 && x >= 10);
Uppgift8(ints, x => x % 2 == 0);




void Uppgift8(int[] array, Func<int,bool>myDelegate)
{
    foreach (var n in array)
    {
        if(myDelegate.Invoke(n) == true)
        {
            Console.WriteLine(n);
        }
    }
}
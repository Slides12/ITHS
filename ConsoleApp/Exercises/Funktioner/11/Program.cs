static int ThrowDice(int diceSize)
{
    Random rnd = new Random();
    int rndNumber = rnd.Next(1, diceSize);
    return rndNumber;
}



static string ThrowMultipleDice(int n, int diceSize = 6)
{
    string sum = "";
    int summan = 0;
    for (int i = 0; i < n; i++)
    {
        int x = ThrowDice(diceSize);
        summan += x;
        sum += $"Tärning {i+1} hade värdet: {x}, Totalt = {summan}. \n" ;
    }
    return sum;
}


Console.WriteLine(ThrowMultipleDice(10));
static string[] SiffrorTillText(params int[] intArray)
{
    string[] numbersInText = new string[] {"Noll","Ett","Två","Tre","Fyra","Fem","Sex","Sju","Åtta","Nio"};
    string[] empty = new string[intArray.Length];
    int indexNumber = 0;
    foreach(int number in intArray)
    {
        for(int i = 0; i <= intArray.Length; i++)
        {

            if(number == i)
            {
                empty[indexNumber] = numbersInText[i];
            }
        }
        indexNumber++;
    }


    return empty;
}



foreach(string word in SiffrorTillText(0, 7, 0, 9, 9, 5, 6, 3, 5, 5))
{
    Console.Write($"{word} ");
}
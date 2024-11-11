static int[] IndexesOf(string text, char character)
{
    int howManyCharacters = 0;
    for(int i = 0;  i < text.Length; i++)
    {
        if(character == text[i])
        {
            howManyCharacters++;
        }
    }
    int[] storedIndex = new int[howManyCharacters];
    int index = 0;

    for (int i = 0; i < text.Length; i++)
    {
        if(character == text[i])
        {
            storedIndex[index] = i;
            index++;
        }
        
    }
    return storedIndex;
}




foreach(int value in IndexesOf("Hello World!", 'o'))
{
    Console.Write($"{value} ");
}



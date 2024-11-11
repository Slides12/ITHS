using System;using System.Collections;

static string IntegerToText(ushort number)
{
    string numberToString = number.ToString();
    ushort[] numberArray = new ushort[numberToString.Length];


    string[] numbersInText = new string[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
    int indexNumber = 0;
    string empty = "";

    for (int i = 0; i < numberToString.Length; i++){ 
        numberArray[i] = UInt16.Parse(numberToString[i].ToString());
    }



    foreach (ushort numb in numberArray)
    {
        for (int i = 0; i <= numbersInText.Length; i++)
        {

            if (numb == i)
            {
                empty += $" {string.Join("",numbersInText[i])}";
                
               

            }
        }
        indexNumber++;
        if (numberArray.Length >= 4 && indexNumber == 1 )
        {
            empty += " Thousand";

        }
        else if (numberArray.Length == 5 && indexNumber == 2 || numberArray.Length == 4 && indexNumber == 2 || numberArray.Length == 3 && indexNumber == 1)
        {
            empty += " Hundred";

        }
        else if (numberArray.Length == 2 && indexNumber == 1 || numberArray.Length == 3 && indexNumber == 2 || numberArray.Length >= 4 && indexNumber == 3)
        {
            if(numb >= 2 && numb <= 9 )
            {
                empty += "ty";

            }
            
        }
    }

    return empty;

}



Console.WriteLine(IntegerToText(6543));
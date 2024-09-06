Console.WriteLine("Skriv en valfri sträng: ");

string userInput = Console.ReadLine();
Console.WriteLine();
bool isMoreThenOne  = false;
string tempString = "";

for (int i = 0; i < userInput.Length; i++)
{
    for(int j = 0;j < userInput.Length; j++) 
    { 
        for(int k = 0;k < userInput.Length; k++)
        {

            if (k >= i && k <= userInput.IndexOf(userInput[i], i + 1))
            {
                tempString += string.Join("", userInput[j]);

                if (tempString.All(char.IsDigit)) { 
                isMoreThenOne = true;
                }
                else
                {
                    //isMoreThenOne = false;

                    tempString = "";

                }
            }
        }

        if (isMoreThenOne) { 
        if(j >= i && j <= userInput.IndexOf(userInput[i],i+1) && char.IsDigit(userInput[i]))
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        else
        {

            Console.ForegroundColor = ConsoleColor.White;
        }

    Console.Write(userInput[j]);
        }
    }
    if (isMoreThenOne) { 
    Console.WriteLine();
    }
    isMoreThenOne = false;
}
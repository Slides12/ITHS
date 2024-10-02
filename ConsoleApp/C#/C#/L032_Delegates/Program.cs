
//DemoDelegate myDelegate = new DemoDelegate(CharCounter);
Func<string,int> myDelegate = WordCounter;


//Console.WriteLine(myDelegate.Invoke("Hello World!"));

Console.WriteLine(myDelegate("Hello World!"));

myDelegate = CharCounter;
//Krashar om  myDelegate = null

Console.WriteLine(myDelegate("Hello World!"));


myDelegate = null;

//Krashar inte om  myDelegate = null

Console.WriteLine(myDelegate?.Invoke("Hello World!"));
Console.WriteLine();

string[] strings = new string[] {"hello world", "hi there", "denmark" };


ProcessStrings(strings, WordCounter);
Console.WriteLine();

ProcessStrings(strings, CharCounter);



static void ProcessStrings(string[] strings, Func<string, int> demoDelegate)
{
    foreach (string s in strings)
    {
        Console.WriteLine(demoDelegate?.Invoke(s));
    }
}

static int CharCounter(string text)
{
    return text.Length;
}


static int WordCounter(string text)
{
    return text.Split(' ').Length;
}


static void PrintHello()
{
    Console.WriteLine("Hello");
}


//public delegate int DemoDelegate(string s);

//Använd generiska delegat (Func (returvärde), Action(inget returvärde)) för att lösa följande uppgifter:

// Miniuppgift 1:
// Skapa en funktion som tar två heltal in, plussar ihop dom och skriver ut resultatet Skapa en generiskt delegat som pekat på metoden
// och använd detta för att anropa metoden.



Console.WriteLine(myDelegate?.Invoke("Hello World!"));

Console.WriteLine("Miniuppgifter");


Action<int, int> myDelegate1 = Add;





static void Add(int x, int y)
{
    Console.WriteLine(x+y);
}



myDelegate1(3,4);



//Miniuppgift 2
//Skapa en funktion som tar en char och en Int in, samt returnerar en string som innehåller bokstaven upprepad det antal gånger som man
// Angett i heltalet. Använd ett generiskt delegat för att anropa metoden. Skriv ut resultatet.


Func<char, int, string> myDelegate2 = AddCharacters;

Console.WriteLine();
Console.WriteLine("Uppgift 2");


static string AddCharacters(char c, int y)
{
    //string returnString = "";
    //for (int i = 0; i < y; i++)
    //{
    //    returnString += c;
    //}
    //return returnString;

    //Över är det jag gjorde, under är den smidigaste varianten av det.

    return new String(c, y);

}


Console.WriteLine(myDelegate2('x', 10));


//Miniuppgift 3;

//Skriv en funktion som tar två heltal in, muliplicerar dem och skriver ut resultatet, Skriv sedan ytterliggare en funktion som tar
//in ett heltal tillsammans med ett delegat till en metod som tar två heltal in. Om man skickar t.ex 3 till denna metoden så ska den ha 
// med funktionen som multiplicerar.


Console.WriteLine();
Console.WriteLine("Uppgift 3");

Action<int, int> myDelegate3 = Multi;

static void Multi(int x, int y)
{
    Console.WriteLine(x * y);
}


static void Heltal(int z, Action<int,int> demoDelegate3)
{
    //demoDelegate3.Invoke(z);
}





Console.WriteLine();
Console.WriteLine("Multicast delegates");
Console.WriteLine();
    

static void FuncA()
{
    Console.WriteLine("FuncA");
}

static void FuncB()
{
    Console.WriteLine("FuncB");
}
static void FuncC()
{
    Console.WriteLine("FuncC");
}

Action action = FuncA;
action += FuncB;
action += FuncC;
action += FuncB;
action += FuncB;
action += FuncA;


action.Invoke();
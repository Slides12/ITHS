

Dictionary<string,string> myDictionary = new Dictionary<string,string>();

myDictionary.Add("boy", "pojke");
myDictionary.Add("girl", "flicka");
myDictionary.Add("man", "man");
myDictionary.Add("woman", "kvinna");



//string input;

//do
//{
//    input = Console.ReadLine();

//    if(myDictionary.ContainsKey(input))
//    {
//        Console.WriteLine(myDictionary[input]);

//    }
//    else
//    {
//        Console.WriteLine("Nyckeln saknas.");
//    }
//} while (input != "");


//Console.WriteLine(myDictionary["girl"]);

Console.WriteLine("Keys:");
foreach (var key in myDictionary.Keys)
{
    Console.WriteLine(key);
}
Console.WriteLine();

Console.WriteLine("Value:");

foreach (var value in myDictionary.Values)
{
    Console.WriteLine(value);
}
Console.WriteLine();

Console.WriteLine("Key value pair:");

foreach (var keyValuePair in myDictionary)
{
    Console.WriteLine(keyValuePair);
}
foreach (var keyValuePair in myDictionary)
{
    Console.WriteLine($"{keyValuePair} {keyValuePair.Key} {keyValuePair.Value}");
}
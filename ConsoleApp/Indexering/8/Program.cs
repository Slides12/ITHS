List<String> ord = new List<String>();
while (true)
{

    Console.WriteLine("Skriv ett ord: ");

    string userInput = Console.ReadLine();  
    ord.Add(userInput);

    if(ord.Count > 10)
    {
        Console.WriteLine($"För 10 ord sedan skrev du {ord[ord.Count-10]}");

    }
    else
    {
        Console.WriteLine("Du har inte skrivit 10 ord ännu.");
    }


}
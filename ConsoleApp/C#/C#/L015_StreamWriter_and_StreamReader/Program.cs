Console.WriteLine(Directory.GetCurrentDirectory());



using (StreamWriter writer = new StreamWriter("myFile.txt", false))
{
    for (int i = 0; i < 10; i++)
    {
        writer.WriteLine($"Hejsan världen! {i}");


    }
}


    

using (StreamReader reader = new StreamReader("myFile.txt"))
{
    while (!reader.EndOfStream) { 
    Console.WriteLine(reader.ReadLine());
        Thread.Sleep(100);
    }

    Console.Write(reader.ReadToEnd());
}






internal class Program
{
    private static async Task Main(string[] args)
    {
        //await Download();

        Console.Out.WriteLineAsync("Start of Main");
        Task task = Download();
        //await Download(); Fungerar också, om du inte använder datan,
        Task<int> taskInt = DownloadInt();


        Console.WriteLine("Main continues...");

        int result = await taskInt; // Returnar en Int
    
        await task; // Returnar en Task

        Console.Out.WriteLineAsync("End of Main");

    }




    private static async Task Download() // Returnar en Task
    {
        HttpClient client = new HttpClient();

        Task<string> download = client.GetStringAsync("https://www.google.com");

        Console.WriteLine("download started...\n");

        string data = await download;
        Console.WriteLine($"Google got these many chars of data: {data.Length}");


        Console.WriteLine("\ndownload complete!");
    }



    private static async Task<int> DownloadInt() // Returnar en Int
    {
        HttpClient client = new HttpClient();

        Task<string> download = client.GetStringAsync("https://www.google.com");

        Console.WriteLine("download started 2...\n");

        string data = await download;
        Console.WriteLine($"Google got these many chars of data: {data.Length}");


        Console.WriteLine("\ndownload complete!");

        return data.Length;
    }
}


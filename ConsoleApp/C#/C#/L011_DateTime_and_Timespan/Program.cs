Console.WriteLine($"DateTime.MinValue {DateTime.MinValue}");
Console.WriteLine($"DateTime.MaxValue {DateTime.MaxValue}");

Console.WriteLine($"DateTime.MaxValue {DateTime.Now}");
Console.WriteLine($"DateTime.MaxValue {DateTime.Today}");

Console.WriteLine($"DateTime.MaxValue {DateTime.UtcNow}");



DateTime myDateTime = DateTime.Now;
Console.WriteLine(myDateTime);




Console.WriteLine(myDateTime.DayOfWeek);
Console.WriteLine(myDateTime.DayOfYear);



Console.WriteLine(myDateTime.AddYears(5));


TimeSpan timeSpan = new TimeSpan();


Console.WriteLine(myDateTime.Subtract(DateTime.Now));

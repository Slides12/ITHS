double[] temperatures = new double[60];
double[] temperatures1 = new double[3] {23.1,22.4,19.4};


for (int i = 0;i < temperatures.Length; i++)
{
    temperatures[i] = 10 + 0.2 * i;
}
for (int i = 0; i < temperatures.Length; i++)
{
    Console.WriteLine(temperatures[i]);
}

for (int i = 0; i < temperatures.Length; i++)
{
    string text = string.Join(", ", temperatures);
    Console.WriteLine(text);
}




Console.WriteLine(temperatures[5]);
Console.WriteLine(temperatures[7]);
Console.WriteLine(temperatures[13]);


Console.WriteLine( temperatures.Length);


string city = "Göteborg";
string[] cities;


foreach(double temperature in temperatures)
{
    Console.WriteLine("hej " + temperature);
}


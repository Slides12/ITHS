# Arrays
    * Är en data struktur som store'ar en satt (fixed) number of literal values (elements) of the same type.

    * 3 different , multidimensional, jagged and single dimensional

    * length can never be changed when its created(run)

    * kan ej använda VAR på arrays


```
double[] temperature = new double[60];
double[] temperature1 = new double[3] {23.1,22.4,19.4};


for (int i = 0;i < temperature.Length; i++)
{
    temperature[i] = 10 + 0.2 * i;
}
for (int i = 0; i < temperature.Length; i++)
{
    Console.WriteLine(temperature[i]);
}

for (int i = 0; i < temperature.Length; i++)
{
    string text = string.Join(", ", temperature);
    Console.WriteLine(text);
}




Console.WriteLine(temperature[5]);
Console.WriteLine(temperature[7]);
Console.WriteLine(temperature[13]);


Console.WriteLine( temperature.Length);
```

# foreach loop
```
foreach(double temperature in temperatures)
{
    Console.WriteLine("hej " + temperature);
}
```



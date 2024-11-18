# IF statement

```
if(x <3){
    Console.Writeline("Hello World");
}
else if(x == 2)
{

}
else if(x == 3)
{

}
else
{

}
```

#### If statement en rad
```
if(x > 3 && x <=10) Console.WriteLine("vadsom");
```


-----------------------------

# Ternary operator
``` 
Console.WriteLine(true ? "Japp!" : "nope"); (om true)
```
``` 
Console.WriteLine(false ? "Japp!" : "nope"); (Om false)
```
### för variabler
```
x = 15

y = (x < 10 ? 5 : 8); (y blir 8 i detta fallet)
```

```
int numberOfPeople = 5;

Console.WriteLine($"{numberOfPeople} person{(numberOfPeople == 1?"":"er")}");
```



-------------------------

# Loopar
```
while(true)
{
    break;
}
```

```
do  (Körs alltid en gång då kodblock är exekvererat)
{
    Console.WriteLine("Hej");

} while (true);
```

```
for(int i = 0; i < 10; i++)
{

}
```
```
foreach(x in array)
{
    
}
```

```
for(int i = 0;i < 10;i++)
{
    if (i == 5)
    {
        Console.WriteLine(i);

        continue; (stoppar loopen här och fortsätter frånbörjan av loopen igen.)

    }

    if (i == 8)
    {
        Console.WriteLine(i);
        break; (Avslutar loopen helt)

    }
}
```

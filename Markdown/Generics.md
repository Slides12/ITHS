# Generics

* Datatypen bestäms i efterhand (När man använder klassen t.ex)
    
```C#
public class Cage<T>
{
    public T Inhabitant {get;set;}
}

Cage<Cage> ballCage = new Cage<Ball>();

// Typen "Ball" kan då ändras till vad du vill.

```

* tillåter en att göra generiska klasser som vid runtime bestämmer vilken typ vi jobbar med.

### List

```C#
List<Cat> cats = new List<Cat>();
cats.Add(leo);
cats.Add(morris);

Cat firstCat = cats[0];
```

### Dictionary
```C#
Dictionary<Cat,Bird> dict = new Dictionary<Cat,Bird>();
dict.Add(morris,fenix);
dict.Add(findus,pippin);
//Key value pair.

Bird findusBird = dict[findus];
```


### Stack
Kallas LIFO (Last in first out)
```C#
Stack<Cat> stack = new Stack <Cat>();
stack.Push(leo);
stack.Push(morris);

Cat topCat = stack.Pop();
```

### Queue
FIFO first in first out
```C#
Queue<Cat> queue = new Queue<Cat>();
queue.Enqueue(Morris);
queue.Enqueue(Leo);

Cat nextCat = queue.Dequeue();
```



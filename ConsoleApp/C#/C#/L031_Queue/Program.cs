﻿
// FIFO first in first out
Queue<string> countries = new Queue<string>();



countries.Enqueue("sweden");
countries.Enqueue("norway");
countries.Enqueue("denmark");


Console.WriteLine(countries.Dequeue());
Console.WriteLine(countries.Dequeue());
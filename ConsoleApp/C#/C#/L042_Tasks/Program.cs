




//Task myTask = Task.Run(Task1);
Task<long> myTask1 = new Task<long>(()=>
{
    long sum = 0;
    for (int i = 1; i <= 500; i++)
    {
        sum += i;
    }
    return sum;
});


Console.WriteLine($"myTask1 is : {myTask1.Status}");

var myContinuationTask = myTask1.ContinueWith(task =>
{
    Console.WriteLine($"The result of task1: {task.Result}");

});

myTask1.Start();

Console.WriteLine($"myTask1 is : {myTask1.Status}");


//Task myTask2 = Task.Run(() =>
//{
//    for (int i = 0; i < 1000; i++)
//    {
//        Console.Write($"-");
//    }
//});



for (int i = 0; i < 1000; i++)
{
    Console.WriteLine($"Main Thread: {i}");
}

Console.WriteLine("Main thread continues...");

//Task.WaitAll(myTask1); //Använd helst inte wait då den låser threaden tills det är klart.


//Console.WriteLine($"The result of task1: {myTask1.Result}"); // Använd ej Result då den också låser threaden.
Console.WriteLine($"myTask1 is : {myTask1.Status}");

Console.WriteLine("The end!");

Console.ReadKey();

//myTask.Wait();
//static void Task1()
//{
//    for (int i = 0; i < 2000; i++)
//    {
//        Console.WriteLine($"Task1: {i}");
//    }
//}





//Exmaple of starting tastk with 2 ContinueWiths


//Task.Run(() =>
//{
//    return "Hello";
//})
//    .ContinueWith(text =>
//    {
//        Console.WriteLine(text.Result);
//        return text.Result[0];
//    })
//    .ContinueWith(text =>
//    {
//        Console.WriteLine(text.Result);
//        return text.Result;
//    })
//    .ContinueWith(text =>
//    {
//        Console.WriteLine(text.Result +"i");
//    });



//***********************************


//Task<string> task1 = Task.Run(() =>
//{
//    return "Hello";
//});

//Task<Char> task2 = task1.ContinueWith(task =>
//{
//    Console.WriteLine(task.Result);
//    return task.Result[0];

//});

//task2.ContinueWith(task =>
//{
//    Console.WriteLine(task.Result);
//});

for (int i = 0;i < 20 ;i++)
{
    Count();

}

static void Count() {

    object myLock = new object();
    int counter = 0;

    Task task1 = Task.Run(() => DoCount());
    Task task2 = Task.Run(() => DoCount());



    //    Task task1 = Task.Run(() =>
    //{

    //    for (int i = 0; i < 10000; i++)
    //    {
    //       int temp =  counter; // temp = 0;
    //        temp = temp + 1; // temp = 1
    //        counter = temp; // counter = 1
    //    }

    //});

    //Task task2 = Task.Run(() =>
    //{

    //    for (int i = 0; i < 10000; i++)
    //    {
    //        counter++;
    //    }

    //});

    Task.WaitAll(task1,task2);

Console.WriteLine($"Count = {counter}");


    void DoCount()
    {
        for (int i = 0; i < 10000; i++)
        {
            lock (myLock) 
            {  // Ta bort lock så räknar den ej korrekt
                int temp = counter; // temp = 0;
                temp = temp + 1; // temp = 1
                counter = temp; // counter = 1
            }
        }
    }
}
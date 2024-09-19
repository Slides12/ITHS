
StepCounter sc = new StepCounter();

for (int i = 0;i < 1000; i++)
{
    sc.Step();

}

Console.WriteLine(sc.Steps);



class StepCounter
{
    private int _steps;
    public int Steps
    {
        get
        {
            return _steps;
        }
    }

    public void Step()
    {
        _steps++;
    }

    public void Reset()
    {
        _steps = 0;
    }
}
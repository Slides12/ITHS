namespace DiEx.Services;

public class SecondTimeService : ITimeService
{
    public string GetCurrentTime()
    {
        return DateTime.Now.ToString();
    }
}
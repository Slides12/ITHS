namespace ÖvningarUnitTests.Core.Services
{
    public static class DueDateService
    {
        public static int DaysUntilDue(DateTime dueDate, DateTime today)
        {
            var days = (dueDate.Date - today.Date).Days;
            return days < 0 ? 0 : days;
        }
    }
}

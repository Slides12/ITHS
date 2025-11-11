namespace StructuraPatternÖV.Classes
{
    public class LoanService
    {
        public void Loan(string memberName, string bookTitle)
        {
            Console.WriteLine($"Lånar ut '{bookTitle}' till {memberName}.");
        }
    }
}

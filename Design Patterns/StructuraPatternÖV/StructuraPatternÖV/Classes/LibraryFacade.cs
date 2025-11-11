namespace StructuraPatternÖV.Classes
{
    public class LibraryFacade
    {
        private readonly BookCatalog _catalog = new();
        private readonly MemberRegistry _members = new();
        private readonly LoanService _loans = new();


        public void BorrowBook(string memberName, string bookTitle)
        {
            if (!_members.RegisterMember(memberName))
            {
                Console.WriteLine($"Medlem '{memberName}' är inte registrerad.");
                return;
            }
            if (!_catalog.FindBook(bookTitle))
            {
                Console.WriteLine($"Boken '{bookTitle}' finns inte i katalogen.");
                return;
            }
            _loans.Loan(memberName, bookTitle);
        }
    }

}


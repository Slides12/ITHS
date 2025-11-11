namespace StructuraPatternÖV.Classes
{
    public class BookCatalog
    {
        private readonly List<string> _books = new() { "Clean Code", "Refactoring", "DesignPatterns" }; 

        public bool FindBook(string title) => _books.Contains(title);
    }
}

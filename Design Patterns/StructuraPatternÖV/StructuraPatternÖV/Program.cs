using StructuraPatternÖV.Classes;

var library = new LibraryFacade();
library.BorrowBook("Anna", "Clean Code");

//Fördelearna med facade är ju att vi de couplar mellan lagrena, och får extre lager av säkerhet.
//Om det inte används i större system, så kan det bli svårt att hålla koll på allt
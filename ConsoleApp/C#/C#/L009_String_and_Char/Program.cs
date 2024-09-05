Console.WriteLine("*** String *****************");

string myString = string.Empty;

myString = "Hello World!";

Console.WriteLine($"Length of myString = {myString.Length}");


Console.WriteLine($"myString.PadLeft() {myString.PadLeft(50,'*')}");
Console.WriteLine($"myString.PadRight() {myString.PadRight(50, '*')}");



Console.WriteLine($"myString.Substring() {myString.Substring(4,3)}");


Console.WriteLine($"myString.Remove() {myString.Remove(4,3)}");


Console.WriteLine($"myString.Replace() {myString.Replace("World", "there")}");


Console.WriteLine($"myString.Insert() {myString.Insert(4, "abc")}");


Console.WriteLine($"myString.IndexOf() {myString.IndexOf('o')}");





Console.WriteLine("*** Char *****************");
char myChar = 'F';


Console.WriteLine($"Char.IsDigit(myChar) {Char.IsDigit(myChar)}");

Console.WriteLine($"Char.IsDigit(myChar) {Char.IsLetter(myChar)}");

Console.WriteLine($"Char.IsDigit(myChar) {Char.IsLetterOrDigit(myChar)}");


Console.WriteLine($"Char.IsDigit(myChar) {Char.IsLetterOrDigit(myChar)}");
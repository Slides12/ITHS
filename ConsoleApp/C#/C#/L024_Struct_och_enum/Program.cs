

Position playerPosition = new Position();

playerPosition.x = 0;
playerPosition.y = 0;

Console.WriteLine($"Player is at position ({playerPosition.x}, {playerPosition.y})");


Color myColor = Color.Green;
Console.WriteLine(myColor);

Console.WriteLine((Color) 5);




// Structs kan inte ärva från andra classer / structs
// Kan ha funktioner etc.
//Blir en value type.
// Skall vara små då stacken endast har 1mb minne. Bättre att göra Funktioner för större saker.
struct Position 
{
    public int x;
    public int y;


    public Position(int x, int y)
    { 
        this.x = x; 
        this.y = y;
    }
}



// Enum sätter namn på int.
enum Color {Red, Green, Blue, Yellow, Purple };
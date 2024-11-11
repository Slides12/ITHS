using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.Intrinsics.X86;

static void DrawBox(int atX, int atY)
{

    int height = 14;
    int width = 14;




    for (int i = 0; i <= height - 1; i++)
    {

        Console.Write("#");
        if (atX < 1)
        {
            atX = 1;
        }
        else if (atX > 12)
        {
            atX = 12;
        }

        if (atY < 1)
        {
            atY = 1;

        }
        else if (atY > 12)
        {
            atY = 12;
        }

        for (int j = 1; j < width - 1; j++)
        {
            if (i == 0 || i == width - 1)
            {
                Console.Write("#");
            }
            else if(j == atX)
            {
                if(i == atY && i != 0 )
                {
                    Console.Write("@");
                }
                else
                {
                    Console.Write("-");

                }
            }
            else
            {
                Console.Write("-");
            }
        }
        Console.Write("#");

        Console.WriteLine();
    }
    Console.WriteLine($"X = {atX}, Y = {atY}");
}


int atPosX = 7;
int atPosY = 7;
DrawBox(atPosX, atPosY);
while (true)
{
    ConsoleKeyInfo cki;
    cki = Console.ReadKey();




    if (atPosX < 1)
    {
        atPosX = 1;
    }
    else if (atPosX > 12)
    {
        atPosX = 12;
    }

    if (atPosY < 1)
    {
        atPosY = 1;

    }
    else if (atPosY > 12)
    {
        atPosY = 12;
    }
    else if (cki.Key == ConsoleKey.LeftArrow)
    {
        DrawBox(atPosX -= 1, atPosY);

    }
    else if (cki.Key == ConsoleKey.RightArrow)
    {
        DrawBox(atPosX += 1, atPosY);

    }
    else if (cki.Key == ConsoleKey.DownArrow)
    {
        DrawBox(atPosX , atPosY += 1);

    }
    else
    {
        DrawBox(atPosX, atPosY -= 1);

    }

}
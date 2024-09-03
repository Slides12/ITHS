using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.Intrinsics.X86;

static char[,] DrawBox(int atPositionX, int atPositionY, int antalObjekt)
{

    int height = 14;
    int width = 14;
    char[,] array2d = new char[height,width];
    Random rnd = new Random();
    int objektCounter = 0;


    for (int i = 0; i <= height - 1; i++)
    {

        Console.Write("#");
        if (atPositionX < 1)
        {
            atPositionX = 1;
        }
        else if (atPositionX > 12)
        {
            atPositionX = 12;
        }

        if (atPositionY < 1)
        {
            atPositionY = 1;

        }
        else if (atPositionY > 12)
        {
            atPositionY = 12;
        }

        for (int j = 1; j < width - 1; j++)
        {
            if (i == 0 || i == width - 1)
            {
                Console.Write("#");
                array2d[i, 0] = '#';
            }
            else if (j == atPositionX)
            {
                if (i == atPositionY && i != 0)
                {
                    Console.Write("@");
                    array2d[i, j] = '@';

                }
                else
                {
                    Console.Write("-");
                    array2d[i, j] = '-';

                }
            }
            else if (rnd.Next(2,12) == i && rnd.Next(2, 12) == j )
            {
                if (objektCounter <= antalObjekt)
                {
                    Console.Write("#");
                    array2d[i, j] = '#';
                }
                    objektCounter++;
            }
            else
            {

                Console.Write("-");
                array2d[i, j] = '-';

            }
        }
        Console.Write("#");

        Console.WriteLine();
    }
    Console.WriteLine($"X = {atPositionX}, Y = {atPositionY}");

    return array2d;
}


int atPosX = 7;
int atPosY = 7;
int antalObjekt = 5;

DrawBox(atPosX, atPosY, antalObjekt);
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
        DrawBox(atPosX -= 1, atPosY, antalObjekt);

    }
    else if (cki.Key == ConsoleKey.RightArrow)
    {
        DrawBox(atPosX += 1, atPosY, antalObjekt);

    }
    else if (cki.Key == ConsoleKey.DownArrow)
    {
        DrawBox(atPosX , atPosY += 1, antalObjekt);

    }
    else
    {
        DrawBox(atPosX, atPosY -= 1, antalObjekt);

    }
}
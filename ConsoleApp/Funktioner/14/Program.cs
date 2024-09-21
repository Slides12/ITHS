using System;

int width = 20;
int height = 10;
int x = width/2;
int y = height/2;
int numbOfObjects = 5;

while (true)
{
    PrintArray(MovePlayer(ref x,ref y,height,width, numbOfObjects), height, width);

    Thread.Sleep(500);
    Console.Clear();
}



static char[,] MovePlayer(ref int xPos, ref int yPos, int height, int width, int numbOfObjects)
{
    ConsoleKeyInfo cki;
    char[,] boxArray = DrawBox(height, width, xPos, yPos, numbOfObjects);

    if (Console.KeyAvailable == true) { 
    cki = Console.ReadKey();


    if (cki.Key == ConsoleKey.RightArrow)
    {
            if(xPos >= width - 2)
            {
                xPos = width - 2;
            }
            else
            {
                xPos += 1;
            }
            
           

            boxArray = DrawBox(height, width, xPos, yPos, numbOfObjects);
        }
        else if (cki.Key == ConsoleKey.LeftArrow)
    {
            if (xPos <= 1)
            {
                xPos = 1;
            }
            else
            {
                xPos -= 1;
            }

            boxArray = DrawBox(height, width, xPos, yPos, numbOfObjects);
        }
        else if (cki.Key == ConsoleKey.DownArrow)
    {
            if (yPos >= height - 2)
            {
                yPos = height - 2;
            }
            else
            {
                yPos += 1;
            }

            boxArray = DrawBox(height, width, xPos, yPos, numbOfObjects);
        }
        else if (cki.Key == ConsoleKey.UpArrow)
    {
            if (yPos <= 1)
            {
                yPos = 1;
            }
            else
            {
                yPos -= 1;
            }

            boxArray = DrawBox(height, width, xPos, yPos, numbOfObjects);
        }
        else { 

    return boxArray;
    }
    }
    return boxArray;

}

static char[,] DrawBox(int height, int width, int xPos, int yPos, int numbOfObjects)
{
    
    Random rand = new Random();
    char[,] yx = new char[height,width];
    int totalObjects = 0;


    for (int i = 0; i <= height - 1; i++)
    {

        yx[i,0] = '#';
        yx[i, width - 1] = '#';




        for (int j = 1; j < width - 1; j++)
        {

            if (i == 0 || i == height - 1)
            {
                yx[i,j] = '#';

            }
            else if (rand.Next(1, height-2) == i && rand.Next(2, width-2) == j)
            {
                if (totalObjects <= numbOfObjects)
                {
                    yx[i, j] = '*';
                }
                totalObjects++;
            }
            else if(i == yPos && j == xPos)
            {
                yx[i, j] = '@';

            }
            else
            {
                yx[i,j] = '-';

            }
        }



    }

    return yx;
}

static void PrintArray(char[,] array, int height, int width)
{
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            Console.Write(array[i, j]);
        }
        Console.WriteLine();
    }
}

static int[,] CreateObjects(int numbOfObjects, int height, int width)
{
    Random rand = new Random();
    int[,] indexOfObjects = new int[numbOfObjects,numbOfObjects];

    for(int i = 0;i < numbOfObjects;i++)
    {
        for (int j = 0; j < numbOfObjects;j++)
        {
            indexOfObjects[i, j] = rand.Next(1,20);
        }
    }
    return indexOfObjects;
}
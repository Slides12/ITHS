int width = 80;
int height = 20;
int obstacles = 5;
//DrawBox(height,width,top,left);

char[,] boxArray = DrawBox(height, width,obstacles);


while (true)
{
    PrintArray(boxArray, height, width);
    Thread.Sleep(2000);

}






static char[,] DrawBox(int height, int width, int obstacles)
{
    
    int left = 0;
    int top = 0;
    char[,] yx = new char[height,width];
    int obstacleCounter = 0;

    for (int i = 0; i <= height - 1; i++)
    {
        Console.SetCursorPosition(left, top);

        yx[i,0] = '#';
        yx[i, width - 1] = '#';




        for (int j = 1; j < width - 1; j++)
        {

            if (i == 0 || i == height - 1)
            {
                yx[i,j] = '#';

            }
            else
            {
                yx[i,j] = '-';

            }
        }
        Console.SetCursorPosition(left, top);



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

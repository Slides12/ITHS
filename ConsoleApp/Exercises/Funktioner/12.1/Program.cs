


while (true)
{
    Random rnd = new Random();
    int width = rnd.Next(3,10);
    int height = rnd.Next(3, 10);
    int left = rnd.Next(1, 80);
    int top = rnd.Next(1, 20);




    DrawBox(left, top, width, height);
    Thread.Sleep(2000);

}






static void DrawBox(int left, int top, int width, int height)
{

    for (int i = 0; i <= height - 1; i++)
    {
        Console.SetCursorPosition(left, top + i);

        Console.Write("#");


        for (int j = 1; j < width - 1; j++)
        {

            if (i == 0 || i == height-1)
            {
                Console.Write("#");
            }
            else
            {
                Console.Write("-");
            }
        }
        Console.SetCursorPosition(left+width-1, top+i);

        Console.Write("#");

        Console.WriteLine();
    }
}

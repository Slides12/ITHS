static void DrawBox(int width, int height)
{
    for (int i = 0; i <= height-1; i++)
    {
        
            Console.Write("#");
        

        for (int j = 1;j < width-1; j++)
        {
            if(i == 0 || i == width-1) { 
            Console.Write("#");
            }
            else
            {
                Console.Write("-");
            }
        }
        Console.Write("#");

        Console.WriteLine();
    }
}

DrawBox(6, 6);
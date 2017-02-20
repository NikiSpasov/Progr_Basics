using System;

class RhombusOfStars
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int x = 1;
        int y = 1;

        for (int row = 0; row < num; row++)
        {
            Console.Write(new string(' ', num - x));
            x++;
            for (int i = 0; i <= row; i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
        for (int i = 0; i < num - 1; i++)
        {
            Console.Write(new string(' ', y));
            y++;
            for (int z = 0; z < num - (i + 1); z++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
        //Console.ReadLine();
    }
}
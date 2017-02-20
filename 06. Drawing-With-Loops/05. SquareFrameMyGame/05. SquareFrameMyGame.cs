using System;

class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        for (int i = 0; i < num; i++)
        {
            if (i == 0 || i == num - 1)
            {
                Console.Write("+ ");
                for (int j = 0; j < num - 2; j++)
                {
                    Console.Write("- ");
                }
                Console.WriteLine("+");
            }
            else
            {
                Console.Write("| ");
                for (int j = 0; j < num - 2; j++)
                {
                    Console.Write("- ");
                }
                Console.WriteLine("|");
            }  
        }
    }
}
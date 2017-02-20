using System;

class Program
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        for (int i = 0; i < num; i++)
        {
            for (int z = 0; z < num - i; z++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }    
    }
}


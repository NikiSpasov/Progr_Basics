using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int firstNum = 1;
        while (firstNum <= n)
        {
            
            Console.Write(firstNum + " ");
            firstNum++;
        }
        Console.WriteLine();
    }
}


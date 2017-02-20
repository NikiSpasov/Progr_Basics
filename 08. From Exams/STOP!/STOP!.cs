using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        //first row
        Console.Write(new string('.', n +1));
        Console.Write(new string('_', (n * 2) +1));
        Console.WriteLine(new string('.', n +1));
        
        //to the middle
        for (int i = 0; i < n; i++)
        {
            Console.Write(new string ('.', n - i));
            Console.Write("//");
            Console.Write(new string('_', (n * 2) - 1 + 2 * i));
            Console.Write(@"\\");
            Console.WriteLine(new string('.', n - i));
        }
        //"Stop!" line
        Console.Write("//");
        Console.Write(new string('_', ((n * 4) - 6) /2));
        Console.Write("STOP!");
        Console.Write(new string('_', ((n * 4) - 6) / 2));
        Console.WriteLine(@"\\");

        //to the bottom
        for (int i = 0; i < n; i++)
        {
            Console.Write(new string('.', i));
            Console.Write(@"\\");
            Console.Write(new string('_', (n * 4) - 1 - 2 * i));
            Console.Write("//");
            Console.WriteLine(new string('.', i));
        }
    }
}


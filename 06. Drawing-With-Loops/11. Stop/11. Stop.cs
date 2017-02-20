using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int newDashes = 0;
        int newDashesBottom = 0;
        //first row
        Console.Write(new string('.', n + 1));
        Console.Write(new string('_', (2 * n) + 1));
        Console.WriteLine(new string('.', n + 1));
        //form second row to the middle, excludind STOP row

        for (int i = 0; i < n; i++)
        {

            Console.Write(new string('.', n - i));
            Console.Write("//");
            Console.Write(new string('_', (n * 2) - 1 + newDashes));
            Console.Write(@"\\");
            Console.WriteLine(new string('.', n - i));
            newDashes += 2;
        }
        //middle row, or STOP! row:
        Console.Write("//");
        Console.Write(new string('_', ((n * 4) - 6) / 2) + "STOP!");
        Console.Write(new string('_', ((n * 4) - 6) / 2));
        Console.WriteLine(@"\\");

        //bottom section
        for (int i = 0; i < n; i++)
        {
            Console.Write(new string('.', (n - n) + i));
            Console.Write(@"\\");
            Console.Write(new string('_', (n * 4) - 1 - newDashesBottom));
            Console.Write("//");
            Console.WriteLine(new string('.', (n - n) + i));
            newDashesBottom += 2;
        }
    }
}
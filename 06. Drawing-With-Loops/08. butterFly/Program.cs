using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n - 2; i++)
        {
            string currentRowChars = "";
            if (i % 2 == 0 )
            {
                currentRowChars = new string('*', n - 2);
            }
            else
            {
                currentRowChars = new string('-', n - 2);
            }
            Console.WriteLine($"{currentRowChars}\\ /{currentRowChars}");
        }

        Console.WriteLine(new string(' ', n - 1) + "@" + new string(' ', n - 1));
        for (int i = 0; i < n - 2; i++)
        {
            string currentRowChars = "";
            if (i % 2 == 0 )
            {
                currentRowChars = new string('*', n - 2);
            }
            else
            {
                currentRowChars = new string('-', n - 2);
            }
            Console.WriteLine($"{currentRowChars}/ \\{currentRowChars}");
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}|", new string(' ', n + 1));
        int spaces = n - 1;
        int stars = 1;
        for (int i = 0; i < n; i++)
        {    
            Console.WriteLine("{0}{1} | {1}{0}", new string(' ', spaces), new string('*', stars));
            stars++;
            spaces--;
        }
    }
}

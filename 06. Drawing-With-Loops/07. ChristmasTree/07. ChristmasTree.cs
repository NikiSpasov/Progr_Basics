using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int x = 1;
        int y = 1;


        Console.Write(new string (' ', n));
        Console.Write(" | ");
        Console.WriteLine(new string(' ', n));
        for (int raw = 0; raw < n; raw++)
        {        
                Console.Write(new string (' ', n-x));      
                Console.Write(new string ('*', n - (n - y)));
                Console.Write(" | ");
                Console.Write(new string('*', n - (n - y)));
            x++;
            y++;
            Console.WriteLine();
        }
        //Console.ReadLine();
    }
}
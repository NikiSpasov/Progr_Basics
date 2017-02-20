using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        

        if (n % 2 != 0)
        {
            Console.Write( new string('-', (n - 1) /2));
            Console.Write('*');
            Console.WriteLine(new string('-', (n - 1) / 2));

            for (int i = 0; i < (n / 2); i++)
            {
                
            }
        }

        else
        {
            Console.Write(new string('-', (n - 2) / 2));
            Console.Write("**");
            Console.WriteLine(new string('-', (n - 2) / 2));

            for (int i = 0; i < n - (n / 2) - 1; i++)
            {

            }
        }
        

    }
}


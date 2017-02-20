using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n == 1)
        {
            Console.WriteLine("*");

            return;
        }
        if (n == 2)
        {
            Console.WriteLine("**");

            return;
        }
        int stars = 1;
        int innerDashes = 1;


        if (n % 2 == 0)
        {
            stars = 2;
            innerDashes = 2;
        }
        int outerDashes = (n - star  s) / 2;
    
        Console.WriteLine("{0}{1}{0}", new string('-', outerDashes), new string('*', stars));

        for (int i = 0; i < n / 2; i++)
        {

        }
        for (int i = 0; i < n / 2 - 1; i++)
        {

        }



        Console.WriteLine("{0}{1}{0}", new string('-', outerDashes), new string('*', stars));
    }
}

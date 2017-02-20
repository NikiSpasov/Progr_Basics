using System;
class testLoops
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n < 2)
        {
            Console.WriteLine("Not Prime");
            return;
        }
        for (int i = 1; i <= n; i++)
        {
            int a = (n - i) % 2;
            if (a == 0)
            {
                Console.WriteLine("Not Prime");
                return;
            }
        }
        Console.WriteLine("Prime");
    }
}



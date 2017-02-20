using System;
class Program
{
    static void Main()
    {
        int n = 2;
        for (int i = 0; i < 999; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(n);
            }
            else
            {
                Console.WriteLine("-" + n);
            }
            n++;
        }
    }
}
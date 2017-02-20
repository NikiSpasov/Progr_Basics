using System;

class Program
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        if (num < 2)
        {
            Console.WriteLine("Not Prime");
            return;
        }
        for (int i = num; i > 1; i--)

            if (num % i == 0)
            {
                Console.WriteLine("Not Prime");
                break;
            }
            else
            {
                Console.WriteLine("Not prime");
                break;
            }
        }
    }
}

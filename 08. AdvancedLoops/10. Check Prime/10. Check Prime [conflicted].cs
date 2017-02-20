using System;

class Program
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        bool prime = true;
        if (num < 2)
        {
            Console.WriteLine("Not Prime");
            return;
        }
        for (int i = 2; i < Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    prime = false;
                break;
                }
            if (prime)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not prime");
            }
            }
        }
    }
}

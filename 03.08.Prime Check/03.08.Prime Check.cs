using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool prime = false;
        if (n < 2)
        {
            Console.WriteLine("false");
            return;
        }
        else if (n == 2)
        {
            Console.WriteLine("true");
            return;
        }

        for (int i = 1; i < n - 1; i++)
        {
            if (n % (n - i) != 0)
            {
                prime = true;
            }
            else
            {
                prime = false;
            }        
        }
        if (prime == true) 
        {
            Console.WriteLine("true");
        }
        else if(prime == false)
        {
            Console.WriteLine("false");
        }
        
    }
}
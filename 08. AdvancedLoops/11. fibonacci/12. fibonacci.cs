using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n < 2)
        {
            Console.WriteLine("1");
        }
        else
        {
            var fibonacci = 0;
            var firstNum = 0;
            var secondNum = 1;
            for (int i = 1; i <= n; n--)
            {            
                fibonacci = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = fibonacci;                
            }
            Console.WriteLine(fibonacci);
        }
    }
}
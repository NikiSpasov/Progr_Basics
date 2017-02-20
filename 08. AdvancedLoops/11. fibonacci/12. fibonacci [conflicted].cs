using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n <= 2)
        {
            Console.WriteLine("1");
        }
        else
        {
            var fibonacci = 2;
            var firstNum = 1;
            var secondNum = 2;
            for (int i = 3; i <= n; n--)
            {            
                fibonacci = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = fibonacci;                
            }
            Console.WriteLine(fibonacci);
        }
    }
}

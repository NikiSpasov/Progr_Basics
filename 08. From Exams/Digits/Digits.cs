using System;

class Digits
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int num = 0;

        int rows = n / 100 + ((n / 10) % 10);
        int cols = n / 100 + n % 10;

        int firstDigit = n / 100;
        int secondDigit = (n / 10) % 10;
        int thirdDigit = n % 10;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (n % 5 == 0)
                {
                    num = n - firstDigit;
                }
                else if (n % 3 == 0)
                {
                    num = n - secondDigit;
                }
                else
                {
                    num = n + thirdDigit;
                }
                Console.Write(num + " ");
                n = num;
            }
            Console.WriteLine();
        } 
    }
}


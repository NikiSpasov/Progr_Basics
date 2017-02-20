using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int lastDigit = n % 10; 
        int thirdDigit = (n / 10) % 10;
        int secondDigit = (n / 100) % 10;
        int firstDigit = (n / 1000) % 10;

        Console.WriteLine(firstDigit + secondDigit + thirdDigit + lastDigit);
        Console.WriteLine("{0}{1}{2}{3}",  lastDigit, thirdDigit, secondDigit, firstDigit);
        Console.WriteLine("{0}{1}{2}{3}", lastDigit, firstDigit, secondDigit, thirdDigit);
        Console.WriteLine("{0}{1}{2}{3}", firstDigit,  thirdDigit, secondDigit, lastDigit);
    }
}
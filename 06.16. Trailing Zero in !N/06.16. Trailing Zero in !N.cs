using System;
using System.Numerics;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger factorial = 1;
        BigInteger trailingZero = 0;
        int cnt = 0;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }

        while (trailingZero == 0)
        {
            trailingZero = factorial % 10;
            factorial = factorial / 10;
            cnt++;
        }
        Console.WriteLine(cnt - 1);
    }
}
//Take the number that you've been given the factorial of.
//Divide by 5; if you get a decimal, truncate to a whole number.
//Divide by 52 = 25; if you get a decimal, truncate to a whole number.
//Divide by 53 = 125; if you get a decimal, truncate to a whole number.
//Continue with ever-higher powers of 5, until your division results in a number less than 1. Once the division is less than 1, stop.
//Sum all the whole numbers you got in your divisions.This is the number of trailing zeroes.

using System;
class Program
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        var sum = 0;
        do
        {
            sum = sum + (a % 10);
            a = a / 10;
        } while (a > 0);

        Console.WriteLine("Sum of digits: {0}", sum);
    }
}
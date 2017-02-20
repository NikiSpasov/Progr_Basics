using System;

class OddOrEven
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine((n % 2 == 0) ? "even " + n : "odd " + n);
    }
}
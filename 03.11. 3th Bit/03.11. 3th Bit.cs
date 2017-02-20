using System;

class Program
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());   
        Console.WriteLine((n >> 3) & 1);
    }
}
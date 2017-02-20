using System;
class Program
{
    static void Main()
    {
        string date = (Console.ReadLine());   
        DateTime dt = Convert.ToDateTime(date);
        Console.WriteLine(dt);
    }
}
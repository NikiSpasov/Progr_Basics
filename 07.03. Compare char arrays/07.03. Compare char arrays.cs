using System;

class Program
{
    static void Main()
    {
        string[] firstCharArr = new string [1];
        firstCharArr[0] = Console.ReadLine();
        string[] secCharArr = new string[1];
        secCharArr[0] = Console.ReadLine();

        if (firstCharArr[0].Length == secCharArr[0].Length)
        {
            Console.WriteLine("=");
        }
        else if (firstCharArr[0].Length > secCharArr[0].Length)
        {
            Console.WriteLine(">");
        }
        else
        {
            Console.WriteLine("<");
        }
    }
}
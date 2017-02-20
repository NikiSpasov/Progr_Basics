using System;

class testLoops
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int firstNum = 1;
        while (firstNum <= n)
        {
            Console.WriteLine(firstNum);
            firstNum += 3;
        }
    }
}
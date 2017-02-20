using System;

class NumbersComparer
{
    static void Main(string[] args)
    {
        double firstNum = double.Parse(Console.ReadLine()); 
        double secondNum = double.Parse(Console.ReadLine());
        Console.WriteLine((firstNum <= secondNum) ? secondNum : firstNum);
    }
}


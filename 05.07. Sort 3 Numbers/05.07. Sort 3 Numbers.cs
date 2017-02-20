using System;

class Program

{
    static void Main()
    {
        short a = short.Parse(Console.ReadLine());
        short b = short.Parse(Console.ReadLine());
        short c = short.Parse(Console.ReadLine());

        short biggestNum = 0;
        short secondNum = 0;
        short smallNum = 0;


        if (a > b && a > c)
        {
            biggestNum = a;
            if (b > c)
            {
                secondNum = b;
                smallNum = c;
            }
            else
            {
                secondNum = c;
                smallNum = b;
            }
        }
        else if (b > a && b > c)
        {
            biggestNum = b;
            if (a > c)
            {
                secondNum = a;
                smallNum = c;
            }
            else
            {
                secondNum = c;
                smallNum = a;
            }
        }
        else
        {
            biggestNum = c;
            if (a > b)
            {
                secondNum = a;
                smallNum = b;
            }
            else
            {
                secondNum = b;
                smallNum = a;
            }
        }
        Console.WriteLine("{0} {1} {2}", biggestNum, secondNum, smallNum);
    }
}
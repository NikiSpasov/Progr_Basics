using System;
class greaterNumber
{
    static void Main()
    {
        var num = double.Parse(Console.ReadLine());
        var num1 = double.Parse(Console.ReadLine());
        if (num > num1)
        {
            Console.WriteLine(num);
        }
        else
        {
            Console.WriteLine(num1);
        }
    }
}
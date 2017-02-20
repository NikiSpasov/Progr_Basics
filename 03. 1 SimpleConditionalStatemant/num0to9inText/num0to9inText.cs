using System;
class num0to9inText
{
    static void Main()
    {
        var a = double.Parse(Console.ReadLine());
        if (a == 0)
        {
            Console.WriteLine("Zero");
        }
        else if (a == 1)
        {
            Console.WriteLine("One");
        }
        else if (a == 2)
        {
            Console.WriteLine("Two");
        }
        else if (a == 3)
        {
            Console.WriteLine("Three");
        }
        else if (a == 4)
        {
            Console.WriteLine("Four");
        }
        else if (a == 5)
        {
            Console.WriteLine("Five");
        }
        else if (a == 6)
        {
            Console.WriteLine("Six");
        }
        else if (a == 7)
        {
            Console.WriteLine("Seven");
        }
        else if (a == 8)
        {
            Console.WriteLine("Eight");
        }
        else if (a == 9)
        {
            Console.WriteLine("Nine");
        }
        else
        { 
            Console.WriteLine("number too big");
        }
    }
}
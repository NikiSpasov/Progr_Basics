using System;

class Program
{
    static void Main()
    {
        string dayOfWeek = Console.ReadLine();
        if (!(dayOfWeek == "1" || dayOfWeek == "2" || dayOfWeek == "3" || dayOfWeek == "4"
            || dayOfWeek == "5" || dayOfWeek == "6" || dayOfWeek == "7"))
        {
            Console.WriteLine("error");
        }

        if (dayOfWeek == "1")
        {
            Console.WriteLine("Monday");
        }
        else if (dayOfWeek == "2")
        {
            Console.WriteLine("Tuesday");
        }
        else if (dayOfWeek == "3")
        {
            Console.WriteLine("Wednesday");
        }
        else if (dayOfWeek == "4")
        {
            Console.WriteLine("Thursday");
        }
        else if (dayOfWeek == "5")
        {
            Console.WriteLine("Friday");
        }
        else if (dayOfWeek == "6")
        {
            Console.WriteLine("Saturday");
        }
        else if (dayOfWeek == "7")
        {
            Console.WriteLine("Sunday");
        }
    }
}
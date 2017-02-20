using System;
namespace checkingLastNumber
{
    class checkingLastNumber
    {
        static void Main(string[] args)
        {
            int i = int.Parse(Console.ReadLine());
            int lastdigit = (i % 10);
            Console.WriteLine(lastdigit);   
        }
    }
}


// This is method to chek the last digit of a number /exm. 1095 (5)/
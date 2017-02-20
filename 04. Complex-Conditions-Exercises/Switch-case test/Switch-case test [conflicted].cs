using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int number = 6;
        switch (number)
        {
            case 1: 
            case 2: 
            case 3: 
            Console.WriteLine("The number is between 1 and 3"); break;
            case 4:
            case 5:
            case 6:
            Console.WriteLine("The number is between 4 and 6"); break;
            default:
            Console.WriteLine("I don't know which number is this!"); break;

        }
    }
}

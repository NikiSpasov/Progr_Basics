using System;

class Program
{
    static void Main()
    {
        var a = Console.ReadLine();
        switch (a)
        {
            case "dog":
            Console.WriteLine("mammal"); break;
            case "crocodile":
            case "tortoise":
            case "snake":
                Console.WriteLine("reptile"); break;
            default:
                Console.WriteLine("unknown"); break;
        }
    }
}
//Write a program to print animal type by its name:
//•	dog -> mammal
//•	crocodile, tortoise, snake -> reptile
//•	others -> unknown

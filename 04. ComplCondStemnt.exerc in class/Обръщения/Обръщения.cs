using System;

class Обръщения
{
    static void Main(string[] args)
    {
        var years = float.Parse(Console.ReadLine());
        string gender = Console.ReadLine();

        if (years >= 16)
        {
            if (gender == "m")
            {
                Console.WriteLine("Mr. ");
            }
            else if (gender == "f")
            {
                Console.WriteLine("Ms. ");
            }
        }
        if (years < 16)
        {
            if (gender == "m")
            {
                Console.WriteLine("Master");
            }
            else if (gender == "f")
            {
                Console.WriteLine("Miss. ");
            }
        }
    }
}


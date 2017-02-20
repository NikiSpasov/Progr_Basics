using System;

class Program
    {
        static void Main()
        {
        string Name = Console.ReadLine();
        string Family = Console.ReadLine();
        int Age = int.Parse(Console.ReadLine());
        string Town = Console.ReadLine();
        Console.WriteLine("You are " + Name + " " + Family + ", a " + Age + "-years old person from " + Town + ".");
        }
    }
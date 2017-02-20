using System;

class Program
{
    static void Main()
    {
        var b1 = double.Parse(Console.ReadLine());
        var b2 = double.Parse(Console.ReadLine());
        var h = double.Parse(Console.ReadLine());
        Console.WriteLine((b1 + b2) * h / 2);
    }
}


//Напишете програма, която чете от конзолата три числа b1, b2 и h и пресмята лицето на трапец 
//с основи b1 и b2 и височина h. Формулата за лице на трапец е (b1 + b2) * h / 2.

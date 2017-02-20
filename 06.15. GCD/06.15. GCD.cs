using System;

class Program
{
    static void Main(string[] args)
    {
        string readNumbers = Console.ReadLine();
        string[] numbers = readNumbers.Split(new char[] { ',', ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);

        int b = int.Parse(numbers[1]);
        int a = int.Parse(numbers[0]);
        
        while (b != 0)

        {
            var oldB = b;
            b = a % b;
            a = oldB;
        }
        Console.WriteLine(a);
    }
}


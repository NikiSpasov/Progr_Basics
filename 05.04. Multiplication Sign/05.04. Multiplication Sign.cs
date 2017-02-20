using System;

class Program
{
    static void Main()
    {
        float a = float.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());
        float c = float.Parse(Console.ReadLine());
        float result = a * b * c;
        if (result < 0)
        {
            Console.WriteLine("-");
        }
        else if (result > 0)
        {
            Console.WriteLine("+");
        }
        else
        {
            Console.WriteLine("0");
        }
    }
}

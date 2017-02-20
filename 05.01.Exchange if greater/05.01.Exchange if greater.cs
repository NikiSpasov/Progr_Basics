using System;

class Program
{
    static void Main()
    {
        double A = double.Parse(Console.ReadLine());
        double B = double.Parse(Console.ReadLine());
        double C = 0;

        if (A > B)
        {
            C = A;
            A = B;
            B = C;
        }
        Console.WriteLine("{0} {1}", A, B);
    }
}

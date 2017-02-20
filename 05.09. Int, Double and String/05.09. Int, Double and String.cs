using System;

class Program
{
    static void Main()
    {
        string varType = Console.ReadLine();
        if (varType == "integer")
        {
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(a + 1);
        }
        else if (varType == "real")
        {
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:f2}", (b+1));
        }
        else if (varType == "text")
        {
            string c = Console.ReadLine();
            Console.WriteLine(c + "*");
        }
    }
}
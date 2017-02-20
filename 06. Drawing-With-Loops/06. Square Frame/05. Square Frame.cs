using System;

class Program
{
    static void Main()
    {
        var number = int.Parse(Console.ReadLine());
        Console.Write("+ ");
        var y = 0;
        var z = 0;
        do
        {
            y++;
            Console.Write("- ");
        } while (y < number - 2);

        Console.WriteLine("+");

        // До тук - Първи ред
        Console.Write("| ");
        for (int i = 0; i <= number - 2; i++)
        {
            Console.Write("- ");                   
        }
        Console.Write("|");
        Console.WriteLine();
        //Console.Write("- ");
        
        //Console.WriteLine();

        
        //от тук надолу - последен ред
        Console.WriteLine("+ ");   
        do
        {
            z++;    
            Console.Write("- ");
        } while (z<number - 2);

        Console.WriteLine("+");
        Console.WriteLine();
    }
}

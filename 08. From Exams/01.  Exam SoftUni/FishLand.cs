using System;

class Program
{
    static void Main()
    {
        double skumriaPrice = double.Parse(Console.ReadLine());
        double cacaPrice = double.Parse(Console.ReadLine());
        double palamudKilo = double.Parse(Console.ReadLine());
        double safridKilo = double.Parse(Console.ReadLine());
        double midiKilo = double.Parse(Console.ReadLine());

        double palamudPricePerKilo = skumriaPrice + ((skumriaPrice * 60) /100);
        double safridPricePerKilo = cacaPrice + ((cacaPrice * 80) / 100);
        double midiPricePerKilo = 7.50;

        double totalPrice = (palamudKilo * palamudPricePerKilo) + (safridKilo * safridPricePerKilo)
            + (midiKilo * midiPricePerKilo);

        Console.WriteLine("{0:0.00}", totalPrice);


    }
}

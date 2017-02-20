using System;

class Rekolta
{
    static void Main()
    {
        int wineArea = int.Parse(Console.ReadLine());
        double kgPerArea = double.Parse(Console.ReadLine());
        int neededWine = int.Parse(Console.ReadLine());
        int workersNeeded = int.Parse(Console.ReadLine());

        double totalKG = wineArea * kgPerArea * 0.4;
        double wineInLitres = totalKG / 2.5;

        if (wineInLitres > neededWine)
        {
            Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(wineInLitres));
            Console.WriteLine(
                "{0} liters left -> {1}, liters per person.",
                Math.Ceiling(wineInLitres - neededWine),
                Math.Ceiling(wineInLitres - neededWine));
        }
        else
        {
            Console.WriteLine("it ...., more {0}..."), Math.Floor(neededWine - wineInLitres);
        }




    }
}

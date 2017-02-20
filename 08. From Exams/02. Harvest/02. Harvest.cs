using System;

class Program
{
    static void Main(string[] args)
    {
        int wineyardArea = int.Parse(Console.ReadLine());
        double grapeFromSquare = double.Parse(Console.ReadLine());
        int wineWantedforSale = int.Parse(Console.ReadLine());
        byte workers = byte.Parse(Console.ReadLine());

        double totalGrape = ((wineyardArea * 40) / 100) * grapeFromSquare;
        double totalWine = totalGrape / 2.5;
        double wineLeft = totalWine - wineWantedforSale;

        if (wineWantedforSale > totalWine)
        {
            Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(wineWantedforSale - totalWine));
        }
        else
        {
            Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(totalWine));
            Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(wineLeft), Math.Ceiling(wineLeft / workers));
        }
    }
}


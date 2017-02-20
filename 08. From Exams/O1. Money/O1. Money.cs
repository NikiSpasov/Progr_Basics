using System;

    class Program
    {
        static void Main()
        {
        int bitCoin = int.Parse(Console.ReadLine());
        double chinaIuan = double.Parse(Console.ReadLine());
        double tax = double.Parse(Console.ReadLine());


        double eurFromBitc = (bitCoin * 1168) / 1.95; 
        double oneChinaIuanInLv = (0.15 * 1.76);
        double eurFromchinaI = (chinaIuan * oneChinaIuanInLv) / 1.95;
        double sum = eurFromBitc + eurFromchinaI;
        double total = sum - (sum * tax) / 100;

        Console.WriteLine(total); 
        }
    }
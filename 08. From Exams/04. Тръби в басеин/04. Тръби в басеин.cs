using System;
class Program
{
    static void Main()
    {
        var poolVolume = int.Parse(Console.ReadLine());
        var debitFirstPipeForHour = int.Parse(Console.ReadLine());
        var debitSecondPipeForHour = int.Parse(Console.ReadLine());
        var hoursWaterFlaws = double.Parse(Console.ReadLine());
       
        var debitTogether = debitFirstPipeForHour + debitSecondPipeForHour;

        double litersOverFlow = (debitTogether * hoursWaterFlaws) - poolVolume;

        double waterInPool = debitTogether * hoursWaterFlaws;

        var litersFromFirstPipe = debitFirstPipeForHour * hoursWaterFlaws;
        var litersFromSecondPipe = debitSecondPipeForHour * hoursWaterFlaws;
        var percentFullPull = (debitTogether * hoursWaterFlaws) / poolVolume * 100;
        var percentFirstPipe = litersFromFirstPipe / waterInPool * 100;
        var percentSecondPipe = litersFromSecondPipe / waterInPool * 100;

        if (waterInPool > poolVolume)
        {
            Console.WriteLine("For " + hoursWaterFlaws + " hours the pool overflows with " + 
                litersOverFlow + " liters.");
        }

        else if (waterInPool <= poolVolume)
        {
            Console.WriteLine("The pool is " + Math.Truncate(percentFullPull) + "% full. Pipe 1: " + 
            Math.Truncate(percentFirstPipe) + "%. Pipe 2: " + Math.Truncate(percentSecondPipe) + "%.");
        } 
    }
}

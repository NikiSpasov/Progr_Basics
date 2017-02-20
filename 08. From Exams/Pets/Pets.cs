using System;

class Pets
{
    static void Main(string[] args)
    {
        int daysVacation = int.Parse(Console.ReadLine());
        int foodLefKilos = int.Parse(Console.ReadLine());
        double dogEat = double.Parse(Console.ReadLine());
        double catEat = double.Parse(Console.ReadLine());
        double turtleEatinGrams = double.Parse(Console.ReadLine());

        double turtleEat = turtleEatinGrams / 1000;

        if ((dogEat + catEat + turtleEat) * daysVacation <= foodLefKilos)
        {
            Console.WriteLine("{0} kilos of food left.", Math.Floor(foodLefKilos - ((dogEat + catEat + turtleEat) * daysVacation)));
        }
        else
        {
            Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(((dogEat + catEat + turtleEat) * daysVacation)) - foodLefKilos);
        }

    }
}

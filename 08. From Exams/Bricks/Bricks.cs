using System;

class Bricks
{
    static void Main(string[] args)
    {
        double brickNum = int.Parse(Console.ReadLine());
        double workers = int.Parse(Console.ReadLine());
        double bricksInCars = int.Parse(Console.ReadLine());

        //how manu cursa trqbwa da narrawqt wsi4ki rabotnici?

        double OverAllcourseNeeded = Math.Ceiling(brickNum / bricksInCars);
        double coursesForAllWorkers = Math.Ceiling(OverAllcourseNeeded / workers);

        Console.WriteLine(coursesForAllWorkers);

    }
}

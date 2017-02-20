using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int daysOff = int.Parse(Console.ReadLine());
        int hoursForPlayOffDay = daysOff * 127;
        int hoursForPlayOnDay = (365 - daysOff) * 63;
        int total = hoursForPlayOnDay + hoursForPlayOffDay;

        int hours = 0;
        int minutes = 0;

        if (total <= 30000)
        {
            hours = (30000 - total) / 60;
            minutes = (30000 - total) % 60;
            Console.WriteLine("Tom sleeps well \n{0} hours and {1} minutes less for play", hours, minutes);
        }
        else
        {
            hours = (total - 30000) / 60;
            minutes = (total - 30000) % 60;
            Console.WriteLine("Tom will run away \n{0} hours and {1} minutes more for play", hours, minutes);
        }
    }
}
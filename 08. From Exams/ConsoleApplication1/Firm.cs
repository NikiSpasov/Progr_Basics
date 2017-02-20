using System;
using System.Collections.Generic;
using System.Linq;

class Firm
{
    static void Main()
    {
        double hoursNeeded = int.Parse(Console.ReadLine());
        double daysFirmHas = double.Parse(Console.ReadLine());
        double workersInFirmOvertime = int.Parse(Console.ReadLine());

        double daysForWork = (double)(daysFirmHas - (daysFirmHas / 10));

        double hours = daysForWork * 8;
        double extraTime = workersInFirmOvertime * (2 * daysFirmHas);
        double totalTime = Math.Floor(hours + extraTime);



        if (hoursNeeded <= totalTime)
        {
            double hoursleft = totalTime - hoursNeeded;
            Console.WriteLine("Yes!{0} hours left.", hoursleft);
        }
        else
        {
            double hoursShort = hoursNeeded - totalTime;
            Console.WriteLine("Not enough time!{0} hours needed.", hoursShort);
        }
    }
}

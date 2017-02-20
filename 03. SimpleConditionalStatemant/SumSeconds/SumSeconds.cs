using System;
class SumSeconds
{
    static void Main()
    {
        int firstRacerTime = int.Parse(Console.ReadLine());
        if (!(firstRacerTime > 0 && firstRacerTime <= 50))
        {
            Console.WriteLine("Wrong Time, please enter a valid time, from 1 to 50!");
        }
        int secondRacerTime = int.Parse(Console.ReadLine());
        if (!(secondRacerTime > 0 && secondRacerTime <= 50))
        {
            Console.WriteLine("Wrong Time, please enter a valid time, from 1 to 50!");
        }
        int thirdRacerTime = int.Parse(Console.ReadLine());
        if (!(thirdRacerTime > 0 && thirdRacerTime <= 50))
        {
            Console.WriteLine("Wrong Time, please enter a valid time, from 1 to 50!");
        }

        int totalSeconds = firstRacerTime + secondRacerTime + thirdRacerTime;
        var timespan = TimeSpan.FromSeconds(totalSeconds);
        Console.WriteLine(timespan.ToString(@"m\:ss"));
    }
}

//Трима спортни състезатели финишират за някакъв брой секунди(между 1 и 50). 
//Да се напише програма, която въвежда времената 
//на състезателите и пресмята сумарното им време във формат 
//"минути:секунди". Секундите да се изведат с 
//водеща нула(2  "02", 7  "07", 35  "35"). 

//int seconds = 1045;
//var timespan = TimeSpan.FromSeconds(seconds);
//Console.WriteLine(timespan.ToString(@"mm\:ss"));


//int totalSeconds = 222;
//int seconds = totalSeconds % 60;
//int minutes = totalSeconds / 60;
//string time = minutes + ":" + seconds;

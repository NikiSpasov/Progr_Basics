using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var max = int.MinValue;
        double numAll = 0;
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (num > max)
            {
                max = num;
            }

            numAll = num + numAll;
        }
        //до тук намерихме най-голямото от въведените - max; и сбора numAll;
        if (max == numAll / 2)
        {
            Console.WriteLine("Yes Sum = {0}", max);
        }
        else
        {
            Console.WriteLine("No Diff = {0}", Math.Abs((numAll - max) - max));
        }
    }
}

//Да се напише програма, която въвежда n цели числа и проверява дали сред тях съществува число, което е
//    равно на сумата на всички останали.Ако има такъв елемент, печата "Yes" + неговата стойност; иначе печата "No"
//+ разликата между най-големия елемент и сумата на останалите(по абсолютна стойност). 
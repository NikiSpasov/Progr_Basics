using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int pokemonsFirst = int.Parse(Console.ReadLine());
        int pokemonsSecond = int.Parse(Console.ReadLine());
        int maxCountbattles = int.Parse(Console.ReadLine());

        int cnt = 0;

        for (int i = 1; i <= pokemonsFirst; i++)
        {
            for (int j = 1; j <= pokemonsSecond; j++)
            {
                cnt++;
                if (cnt > maxCountbattles)
                {
                    break;
                }
                Console.Write("({0} <-> {1}) ", i, j);
                
            }
        }
    }
}


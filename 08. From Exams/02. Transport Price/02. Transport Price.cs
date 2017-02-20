
//Студент трябва да пропътува n километра.Той има избор измежду три вида транспорт:
//•	Такси.Начална такса: 0.70 лв.Дневна тарифа: 0.79 лв. / км.Нощна тарифа: 0.90 лв. / км.
//•	Автобус.Дневна / нощна тарифа: 0.09 лв. / км.Може да се използва за разстояния минимум 20 км.
//•	Влак.Дневна / нощна тарифа: 0.06 лв. / км.Може да се използва за разстояния минимум 100 км.
//Напишете програма, която въвежда броя километри n и период от деня (ден или нощ) и изчислява цената на най-евтиния транспорт.
//Вход
//От конзолата се четат два реда:
//•	Първият ред съдържа числото n – брой километри – цяло число в интервала [1…5000].
//•	Вторият ред съдържа дума “day” или “night” – пътуване през деня или през нощта.
//Изход
//Да се отпечата на конзолата най-ниската цена за посочения брой километри.

using System;
class Program
{
    static void Main()
    {
        int kilometers = int.Parse(Console.ReadLine());
        string dayOrNight = Console.ReadLine();

        if (kilometers > 5000 || kilometers < 1)
        {
            Console.WriteLine("Error!");
            Console.ReadLine();
        }

        var taxyDay = 0.7 + kilometers * 0.79;
        var taxyNight = 0.7 + kilometers * 0.9;
        var bus = 0.09 * kilometers;
        var train = 0.06 * kilometers;

        if (dayOrNight == "night")
        {
            if (kilometers >= 100)
            {
                Console.WriteLine(train);
            }
            else if (kilometers < 100 && kilometers >= 20)
            {
                Console.WriteLine(bus);
            }
            else if (kilometers < 20 && kilometers > 0)
            {
                Console.WriteLine(taxyNight);
            }
            else
            {
                Console.WriteLine();
            }
        }

        if (dayOrNight == "day")
        {
            if (kilometers >= 100)
            {
                Console.WriteLine(train);
            }
            else if (kilometers < 100 && kilometers > 20)
            {
                Console.WriteLine(bus);
            }
            else if (kilometers < 20 && kilometers > 0)
            {
                Console.WriteLine(taxyDay);
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        if (n < 5)
        {
            for (int i = 0; i < n - (n / 2); i++)
            {
                Console.Write("/");
                Console.Write(new string('^', n / 2));
                Console.Write(@"\");
            }
        }
        else
        {
            for (int i = 0; i < n - (n - 1); i++)
            {
                Console.Write("/");
                Console.Write(new string('^', n / 2));
                Console.Write(@"\");
                for (int j = 0; j < n / 2; j++)
                {
                    Console.Write("_");
                }
                Console.Write("/");
                Console.Write(new string('^', n / 2));
                Console.Write(@"\");
            }
        }
        Console.WriteLine();

        if (n < 5)
        {
            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine("|" + new string(' ', (n * 2) - 2) + "|");
            }
        }
        else
        {
            for (int i = 0; i < n - 3; i++)
            {
                Console.WriteLine("|" + new string(' ', (n * 2) - 2) + "|");
            }
            Console.WriteLine("|" + new string(' ', ((n / 2) + 1))
                                      + new string('_', n / 2)
                                      + new string(' ', ((n / 2) + 1)) + "|");
        }

        if (n < 5)
        {
            for (int i = 0; i < n - (n / 2); i++)
            {
                Console.Write(@"\");
                Console.Write(new string('_', n / 2));
                Console.Write("/");
            }
        }
        else
        {
            for (int i = 0; i < n - (n - 1); i++)
            {
                Console.Write(@"\");
                Console.Write(new string('_', n / 2));
                Console.Write("/");
                for (int j = 0; j < n / 2; j++)
                {
                    Console.Write(" ");
                }
                Console.Write(@"\");
                Console.Write(new string('_', n / 2));
                Console.Write("/");
            }
        }
        Console.WriteLine();
    }
}

//Да се напише програма, която прочита от конзолата цяло число n и чертае крепост с ширина 2 * n колони 
//    и височина n реда като в примерите по-долу.
//    Лявата и дясната колона във вътрешността си са широки n / 2.

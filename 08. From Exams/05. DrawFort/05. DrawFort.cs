using System;

class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        Console.Write("/");
        Console.Write(new string('^', n / 2));
        Console.Write("'\'");
    }
}

//Да се напише програма, която прочита от конзолата цяло число n и чертае крепост с ширина 2 * n колони 
//    и височина n реда като в примерите по-долу.
//    Лявата и дясната колона във вътрешността си са широки n / 2.

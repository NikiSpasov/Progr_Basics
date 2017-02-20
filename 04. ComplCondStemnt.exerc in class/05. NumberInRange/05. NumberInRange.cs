using System;

class Program
{
    static void Main(string[] args)
    {
        var num = int.Parse(Console.ReadLine());
        if (num <= 200 && num >= 100 || num == 0)
        {
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("invalid");
        }
    }
}

//Дадено число е валидно, ако е в диапазона[100…200] или е 0. Да се напише програма, която въвежда цяло число и 
//    печата “invalid” ако въведеното число не е валидно.Примери:
//вход изход       вход изход       вход изход       вход изход
//75	invalid     150	(няма изход)        220	invalid		199	(няма изход)

//вход изход       вход изход       вход изход       вход изход
//-1	invalid		100	(няма изход)		200	(няма изход)		0	(няма изход)

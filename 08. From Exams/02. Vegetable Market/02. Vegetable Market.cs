using System;

namespace _02.Vegetable_Market
{
    class Program
    {
        static void Main()
        {
            double vegetToKilo = double.Parse(Console.ReadLine());
            double fruitToKilo = double.Parse(Console.ReadLine());
            int vegetTotal = int.Parse(Console.ReadLine());
            int fruitTotal = int.Parse(Console.ReadLine());

            var profitVeget = vegetTotal * vegetToKilo;
            var profitFruit = fruitTotal * fruitToKilo;
            double sum = (profitVeget + profitFruit) / 1.94;
            Console.WriteLine("{0}", sum);
        }
    }
}
//Градинар продавал реколтата от градината си на зеленчуковата борса.
//Продава зеленчуци за N лева на килограм и плодове за M лева за килограм.
//Напишете програма, която да пресмята приходите от реколтата в евро 
//( ако приемем, че едно евро е равно на 1.94лв).
//Вход
//От конзолата се четат 4 числа, по едно на ред:
//•	Първи ред – Цена за килограм зеленчуци – число с плаваща запетая
//•	Втори ред – Цена за килограм плодове – число с плаваща запетая
//•	Трети ред – Общо килограми на зеленчуците – цяло число
//•	Четвърти ред – Общо килограми на плодовете – цяло число
//Ограничения: Всички числа ще са в интервала от 0.00 до 1000.00
//Изход
//Да се отпечата на конзолата едно число с плаваща запетая: приходите от всички плодове и 
//зеленчуци в евро.

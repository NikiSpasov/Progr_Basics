//6.	Точка върху страната на правоъгълник
//Напишете програма, която проверява дали точка { x, y }
//се намира върху някоя от страните на правоъгълник { x1, y1 } – {x2, y2}. Входните данни се четат от конзолата и се състоят от 6 реда: десетичните числа x1, y1, x2, y2, x и y(като се гарантира, че x1 < x2 и y1<y2). Да се отпечата “Border” (точката лежи на някоя от страните) или “Inside / Outside” (в противен случай). Примери:

//Тествайте решението си в judge системата: https://judge.softuni.bg/Contests/Practice/Index/153#5.
//* Подсказка: използвайте една или няколко условни if проверки с логически операции.Точка { x, y }
//лежи върху някоя от страните на правоъгълник {x1, y1} – {x2, y2}, ако е изпълнено едно от следните условия:
//•	x съвпада с x1 или x2 и същевременно y е между y1 и y2

//Можете да проверите горните условия с една по-сложна if-else конструкция или с няколко
//по-прости проверки или с вложени if-else проверки.

using System;

namespace _06.Point_on_Rectangle_Border
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            if ((x == x1 || x == x2) && (y1 <= y) && (y <= y2))
            {
                Console.WriteLine("Border");
            }
            else if ((y == y1 || y == y2) && (x1 <= x) && (x <= x2))
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}

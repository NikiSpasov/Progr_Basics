using System;

class PointOnBorder
{
    static void Main(string[] args)
    {
        var x1 = double.Parse(Console.ReadLine());
        var y1 = double.Parse(Console.ReadLine());
        var x2 = double.Parse(Console.ReadLine());
        var y2 = double.Parse(Console.ReadLine());
        var x = double.Parse(Console.ReadLine());
        var y = double.Parse(Console.ReadLine());

        if (!(x1 < x2 && y1 < y2))
        {
            Console.WriteLine("Invalid input!");
        }

        var firstCase = (x == x1 || x == x2) && (y >= y1 && y <= y2);
        var secondCase = (y == y1 || y == y2) && (x >= x1 && x <= x2);

        if (firstCase || secondCase)
        {
            Console.WriteLine("Border");
        }
        else 
        {
            Console.WriteLine("Inside / Outside");
        }
    }
}

//x съвпада с x1 или x2 и същевременно y е между y1 и y2
////•	y съвпада с y1 или y2 и същевременно x е между x1 и x2

//Напишете програма, която проверява дали точка {x, y} се намира върху някоя
//    от страните на правоъгълник { x1, y1 } – {x2, y2}. Входните данни се четат от конзолата и
//    се състоят от 6 реда: десетичните числа x1, y1, x2, y2, x и y(като се гарантира, че x1 < x2 и y1<y2). 
//Да се отпечата “Border” (точката лежи на някоя от страните) или “Inside / Outside” (в противен случай). 
//    Примери:
//вход изход   визуализация вход    изход визуализация
//2
//-3
//12
//3
//8
//-1
//	Inside / Outside	 		2
//-3
//12
//3
//12
//-1
//	Border
//Тествайте решението си в judge системата: https://judge.softuni.bg/Contests/Practice/Index/153#5.
//* Подсказка: използвайте една или няколко условни if проверки с логически операции.Точка { x, y }
//лежи върху някоя от страните на правоъгълник {x1, y1} – {x2, y2}, ако е изпълнено едно от следните условия:
//•	
//Можете да проверите горните условия с една по-сложна if-else конструкция или с няколко по-прости 
//    проверки или с вложени if-else проверки.

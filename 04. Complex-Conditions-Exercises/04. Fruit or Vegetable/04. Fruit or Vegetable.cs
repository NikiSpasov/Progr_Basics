using System;

class Program
{
    static void Main()
    {
        var a = Console.ReadLine();

        if (a == "banana" || a == "apple" || a == "kiwi" || a == "cherry" || a == "lemon" || a == "grapes")
        {
            Console.WriteLine("fruit");
        }
        else if (a == "tomato" || a == "cucumber" || a == "pepper" || a == "carrot")
        {
            Console.WriteLine("vegetable");
        }
        else
        {
            Console.WriteLine("unknown");
        }
    }
}


//Да се напише програма, която въвежда име на продукт и проверява дали е плод или зеленчук.
//•	Плодовете "fruit" са banana, apple, kiwi, cherry, lemon и grapes
//•	Зеленчуците "vegetable" са tomato, cucumber, pepper и carrot
//•	Всички останали са "unknown"
//Да се изведе “fruit”, “vegetable” или “unknown” според въведения продукт.Примери:
//вход изход       вход изход       вход изход       вход изход
//banana fruit       apple fruit       tomato vegetable       water unknown

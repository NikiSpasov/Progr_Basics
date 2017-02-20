using System;

class Program
{
    static void Main()
    {
        string fruitOrVegetable = Console.ReadLine();
        if (fruitOrVegetable == "banana" || fruitOrVegetable == "apple" || fruitOrVegetable == "kiwi" || 
            fruitOrVegetable == "cherry" || fruitOrVegetable == "lemon" || fruitOrVegetable == "grapes")
        {
            Console.WriteLine("fruit");
        }
        else if (fruitOrVegetable == "tomato" || fruitOrVegetable == "cucumber" || 
                 fruitOrVegetable == "pepper" || fruitOrVegetable == "carrot")
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
//Тествайте решението си в judge системата: https://judge.softuni.bg/Contests/Practice/Index/153#3.
//* Подсказка: използвайте условна if проверка с логическо „или“ – operator ||.

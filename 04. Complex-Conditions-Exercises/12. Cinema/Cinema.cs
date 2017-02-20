using System;

class Program
{
    static void Main()
    {
        var typeMovie = Console.ReadLine().ToLower();
        if (!(typeMovie == "premiere" || typeMovie == "normal"|| typeMovie == "discount"))
        {
            Console.WriteLine("Error input, please write Premiere, normal or discount");
        }
        var r = double.Parse(Console.ReadLine());
        var c = double.Parse(Console.ReadLine());

        switch (typeMovie)
        {
            case "premiere":
                double result = (r * c * 12.00);
                Console.WriteLine("{0:f2}", result + " leva"); break;
            case "normal":
                result = (r * c * 7.50);
                Console.WriteLine("{0:f2}", result + " leva"); break;
            case "discount":
                result = (r * c * 5.00);
                Console.WriteLine("{0:f2}", result + " leva"); break;

            default:
                Console.WriteLine("Invalid Input");
                break;
        }
    }
}

//В една кинозала столовете са наредени в правоъгълна форма в r реда и c колони.
//Има три вида прожекции с билети на различни цени:
//•	Premiere – премиерна прожекция, на цена 12.00 лева.
//•	Normal – стандартна прожекция, на цена 7.50 лева.
//•	Discount – прожекция за деца, ученици и студенти на намалена цена от 5.00 лева.
//Напишете програма, която въвежда тип прожекция(стринг), брой редове и брой колони в 
//залата(цели числа) и изчислява общите приходи от билети при пълна зала.
//Резултатът да се отпечата във формат като в примерите по-долу,
//с 2 знака след десетичната точка.Примери:
//вход изход       вход изход       вход изход
//Premiere
//10
//12	1440.00 leva Normal
//21
//13	2047.50 leva Discount
//12
//30	1800.00 leva
//Тествайте решението си в judge системата: https://judge.softuni.bg/Contests/Practice/Index/153#8.
//* Подсказка: използвайте прости проверки и елементарни изчисления.
//За да изведете резултата с точно 2 цифри след десетичната точка, използвайте 
//Console.WriteLine("{0:f2}", result).
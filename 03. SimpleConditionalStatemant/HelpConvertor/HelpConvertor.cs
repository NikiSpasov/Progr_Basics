using System;

class Currency_Converter
{
    static void Main()
    {
        var USD = 1.79549;
        var EUR = 1.95583;
        var GBP = 2.53405;
        var x = double.Parse(Console.ReadLine());
        var firstCurency = Console.ReadLine();
        var secondCurrency = Console.ReadLine();
        var moneyInleva = 0.00;

        if (firstCurency == "USD")
        {
            moneyInleva = x * USD;
        }
        else if (firstCurency == "EUR")
        {
            moneyInleva = x * EUR;
        }
        else if (firstCurency == "GBP")
        {
            moneyInleva = x * GBP;
        }
        else if (firstCurency == "BGN")
        {
            moneyInleva = x;
        }

        var MoneyInWanted = 0.00;

        if (secondCurrency == "USD")
        {
            MoneyInWanted = moneyInleva / USD;
        }
        else if (secondCurrency == "EUR")
        {
            MoneyInWanted = moneyInleva / EUR;
        }
        else if (secondCurrency == "GBP")
        {
            MoneyInWanted = moneyInleva / GBP;
        }
        else if (secondCurrency == "BGN")
        {
            MoneyInWanted = moneyInleva;
        }

        Console.WriteLine("{0:0.00} {1}", MoneyInWanted, secondCurrency);
    }
}
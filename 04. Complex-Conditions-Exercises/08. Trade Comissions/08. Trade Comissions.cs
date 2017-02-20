//8.	Търговски комисионни
//Фирма дава следните комисионни на търговците си според града, в който работят и обема на продажбите s:
//Град	0 ≤ s ≤ 500	500 < s ≤ 1 000	1 000 < s ≤ 10 000	s > 10 000
//Sofia	5%	7%	8%	12%
//Varna	4.5%	7.5%	10%	13%
//Plovdiv	5.5%	8%	12%	14.5%
//Напишете конзолна програма, която чете име на град(стринг) и обем на продажби(десетично число) и изчислява и
//    извежда размера на търговската комисионна според горната таблица.Резултатът да се изведе закръглен с 2 цифри 
//    след десетичната точка.При невалиден град или обем на продажбите (отрицателно число) да се отпечата “error”. 
//* Подсказки:
//•	Прочетете входа и обърнете града в малки букви(като в предходната задача).
//•	Първоначално задайте комисионна -1. Тя ще бъде променена, ако градът и ценовият диапазон бъдат намерени в
//    таблицата с комисионните.
//•	Използвайте вложени if проверки, за да изчислите комисионната според града и според обема 
//        на продажбите.Може да си помогнете с кода по-долу:



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        double commission;
        var townName = Console.ReadLine().ToLower();
        double sales = double.Parse(Console.ReadLine());

        if (!(townName == "sofia" || townName == "plovdiv" || townName == "varna") || sales < 0)
        {
            Console.WriteLine("error");
        }

        if (townName == "sofia" && 0 <= sales && sales <= 500)
        {
            commission = 0.05;
            Console.WriteLine("{0:f2}", commission * sales);
        }
        else if (townName == "sofia" && 500 < sales && sales <= 1000)
        {
            commission = (7 * sales / 100);
            Console.WriteLine("{0:f2}", commission);
        }
        else if (townName == "sofia" && 1000 < sales && sales <= 10000)
        {
            commission = (8 * sales / 100);
            Console.WriteLine("{0:f2}", commission);
        }
        else if (townName == "sofia" && 10000 < sales)
        {
            commission = (12 * sales / 100);
            Console.WriteLine("{0:f2}", commission);
        }

        else if (townName == "varna" && 0 <= sales && sales <= 500)
        {
            commission = (4.5 * sales / 100);
            Console.WriteLine("{0:f2}", commission);
        }
        else if (townName == "varna" && 500 < sales && sales <= 1000)
        {
            commission = (7.5 * sales / 100);
            Console.WriteLine("{0:f2}", commission);
        }
        else if (townName == "varna" && 1000 < sales && sales <= 10000)
        {
            commission = (10 * sales / 100);
            Console.WriteLine("{0:f2}", commission);
        }
        else if (townName == "varna" && 10000 < sales)
        {
            commission = (13 * sales / 100);
            Console.WriteLine("{0:f2}", commission);
        }

        else if (townName == "plovdiv" && 0 <= sales && sales <= 500)
        { 
            commission = (5.5 * sales / 100);
            Console.WriteLine("{0:f2}", commission);
        }
        else if (townName == "plovdiv" && 500 < sales && sales <= 1000)
        {
              commission = (8 * sales / 100);
              Console.WriteLine("{0:f2}", commission);
        }
        else if (townName == "plovdiv" && 1000 < sales && sales <= 10000)
        {
            commission = (12 * sales / 100);
            Console.WriteLine("{0:f2}", commission);
        }
        else
        {
            commission = (14.5 * sales / 100);
            Console.WriteLine("{0:f2}", commission);
         }
        }
    }



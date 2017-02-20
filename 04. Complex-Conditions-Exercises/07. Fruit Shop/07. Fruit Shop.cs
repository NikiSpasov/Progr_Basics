//Магазин за плодове през работните дни работи на следните цени:
//плод banana  apple   orange  grapefruit kiwi    pineapple grapes
//цена	2.50	1.20	0.85	1.45	  2.70	    5.50	3.85

//Събота и неделя магазинът работи на по-високи цени:
//плод banana  apple   orange  grapefruit kiwi    pineapple   grapes
//цена	2.70	1.25	0.90	1.60	  3.00   	5.60       4.20

//    Напишете програма, която чете от конзолата
//    плод(banana / apple / orange / grapefruit / kiwi / pineapple / grapes), 
//    ден от седмицата(Monday / Tuesday / Wednesday / Thursday / Friday / Saturday / Sunday)
//    и количество (десетично число) и пресмята цената според цените от таблиците по-горе.
//    Резултатът да се отпечата закръглен с 2 цифри след десетичната точка.
//    При невалиден ден от седмицата или невалидно име на плод да се отпечата “error”. Примери:



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var a = "banana";
        var b = "apple";
        var c = "orange";
        var d = "grapefruit";
        var e = "kiwi";
        var f = "pineapple";
        var g = "grapes";


        string fruit = Console.ReadLine();
        if (!(fruit == a || fruit == b || fruit == c || fruit == d || fruit == e || fruit == f || fruit == g))
        {
            Console.WriteLine("error");
        }
        string dayOfWeek = Console.ReadLine();
        if (!(dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday"
           || dayOfWeek == "Friday" || dayOfWeek == "Saturday" || dayOfWeek == "Sunday"))
        {
            Console.WriteLine("error");
        }

        double quantity = double.Parse(Console.ReadLine());

        if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday"
        || dayOfWeek == "Friday")
            if (fruit == a)
            {
                Console.WriteLine(quantity * 2.50);
            }
            else if (fruit == b)
            {
                Console.WriteLine(quantity * 1.20);
            }
            else if (fruit == c)
            {
                Console.WriteLine(quantity * 0.85);
            }
            else if (fruit == d)
            {
                Console.WriteLine(quantity * 1.45);
            }
            else if (fruit == e)
            {
                Console.WriteLine(quantity * 2.70);
            }
            else if (fruit == f)
            {
                Console.WriteLine(quantity * 5.50);
            }
            else if (fruit == g)
            {
                Console.WriteLine(quantity * 3.85);
            }

        if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
        {
            if (fruit == a)
            {
                Console.WriteLine(quantity * 2.70);
            }
            else if (fruit == b)
            {
                Console.WriteLine(quantity * 1.25);
            }
            else if (fruit == c)
            {
                Console.WriteLine(quantity * 0.90);
            }
            else if (fruit == d)
            {
                Console.WriteLine(quantity * 1.60);
            }
            else if (fruit == e)
            {
                Console.WriteLine(quantity * 3.00);
            }
            else if (fruit == f)
            {
                Console.WriteLine(quantity * 5.60);
            }
            else if (fruit == g)
            {
                Console.WriteLine(quantity * 4.20);
            }
        }
    }
}
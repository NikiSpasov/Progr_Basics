using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace METRIC_CONVERTER
{
    class Program
    {
        static void Main(string[] args)
        {
            double numbersToConvert = double.Parse(Console.ReadLine());
            string firstNumber = Console.ReadLine();
            string secondNumber = Console.ReadLine();
            var currencies = new Dictionary<string, double>()
            {
                {"m", 1},
                {"mm", 1000 },
                {"cm", 100 },
                {"mi", 0.000621371192},
                {"in", 39.3700787},
                {"km", 0.001},
                {"ft", 3.2808399},
                {"yd", 1.0936133}
            };
            double result = numbersToConvert / currencies[firstNumber] * currencies[secondNumber];

            Console.WriteLine("{0} {1}", result, secondNumber);
        }
    }
}

//Да се напише програма, която преобразува разстояние между следните 8 мерни единици: m, mm, cm, mi, in, km, ft, yd.
//Използвайте съответствията от таблицата по-долу:
//входна единица  изходна единица
//1 meter(m) 1000 millimeters(mm)
//1 meter(m) 100 centimeters(cm)
//1 meter(m) 0.000621371192 miles(mi)
//1 meter(m) 39.3700787 inches(in)
//1 meter(m) 0.001 kilometers(km)
//1 meter(m) 3.2808399 feet(ft)3685
//1 meter(m) 1.0936133 yards(yd)
//Входните данни се състоят от три реда:
//•	Първи ред: число за преобразуване
//•	Втори ред: входна мерна единица
//•	Трети ред: изходна мерна единица(за резултата)
//Примерен вход и изход:
//вход изход       вход изход       вход изход
//12
//km
//ft  39370.0788 ft		150 mi in	9503999.99393599 mi		450
//yd
//km  0.41147999937455 yd

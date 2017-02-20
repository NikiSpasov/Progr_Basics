using System;

class Program
{
    static void Main()
    {
        var numberToConvert = double.Parse(Console.ReadLine());
        var input = Console.ReadLine();
        var output = Console.ReadLine();


        if (input == "m" && output == "mm")
        {
            Console.WriteLine(numberToConvert * 1000);
        }
        else if (output == "cm")
        {
            Console.WriteLine(numberToConvert * 100);
        }
        else if (output == "in")
        {
            Console.WriteLine(numberToConvert * 39.3700787);
        }
        else if (output == "yd")
        {
            Console.WriteLine(numberToConvert * 1.0936133);
        }
        else if (output == "ft")
        {
            Console.WriteLine(numberToConvert * 3.2808399);
        }
        else if (output == "km")
        {
            Console.WriteLine(numberToConvert / 1000);
        }
        else if (output == "mi")
        {
            Console.WriteLine(numberToConvert * 0.000621371192);
        }

        if (input == "mm" && output == "m")
        {
            Console.WriteLine(numberToConvert / 1000);
        }
        else if (output == "cm")
        {
            Console.WriteLine(numberToConvert * 10);
        }
        else if (output == "in")
        {
            Console.WriteLine(numberToConvert * 39370.0787);
        }
        else if (output == "yd")
        {
            Console.WriteLine(numberToConvert * 1093.6133);
        }
        else if (output == "ft")
        {
            Console.WriteLine(numberToConvert * 3280.8399);
        }
        else if (output == "km")
        {
            Console.WriteLine(numberToConvert / 1000000);
        }
        else if (output == "mi")
        {
            Console.WriteLine(numberToConvert * 0.000000621371192);
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

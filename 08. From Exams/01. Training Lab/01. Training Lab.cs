using System;

class Program
{
    static void Main()
    {
        double hLenghtInMeters = double.Parse(Console.ReadLine());
        double wWideInMeters = double.Parse(Console.ReadLine());

        double rows = hLenghtInMeters / 1.2;
        var rowsRounded = Math.Floor(rows);
       
        double column = (wWideInMeters - 1) / 0.7;
        var columnRounded = Math.Floor(column);
        double workingPlaces = (rowsRounded * columnRounded) - 3;

        Console.WriteLine(Math.Floor(workingPlaces));   
    }
}

//Учебна зала има правоъгълен размер w на h метра, без колони във вътрешността си.
//Залата е разделена на две части – лява и дясна, с коридор приблизително по средата.
//В лявата и в дясната част има редици с бюра.
//В задната част на залата има голяма входна врата. 
//В предната част на залата има катедра с подиум за преподавателя.Едно работно място заема 70 на 120 cm
//(маса с размер 70 на 40 cm + място за стол и преминаване с размер 70 на 80 cm). 
//Коридорът е широк поне 100 cm. Изчислено е, че заради входната врата(която е с отвор 160 cm)
//се губи точно 1 работно място, а заради катедрата(която е с размер 160 на 120 cm) се губят
//точно 2 работни места.
//Напишете програма, която въвежда размери на учебната зала и изчислява
//броя работни места в нея при описаното разположение (вж.фигурата).
//Вход
//От конзолата се четат 2 числа, по едно на ред: h(дължина в метри) и w(широчина в метри).
//Ограничения: 3 ≤ h ≤ w ≤ 100.
//Изход
//Да се отпечата на конзолата едно цяло число: броят места в учебната зала.
//Math.Ceiling
//always rounds up(towards the ceiling)

//Math.Floor
//always rounds down(towards to floor)

//what you are after is simply
//var roundedA = Math.Round(1.1, 0); // Output: 1
//var roundedB = Math.Round(1.5, 0, MidpointRounding.AwayFromZero); // Output: 2
//var roundedC = Math.Round(1.9, 0); // Output: 2
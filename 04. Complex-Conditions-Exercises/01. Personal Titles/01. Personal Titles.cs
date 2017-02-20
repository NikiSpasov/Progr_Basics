using System;

class Program
{
    static void Main()
    {
        float age = float.Parse(Console.ReadLine());
        var gender = Console.ReadLine();

        string femaleYoung = "Miss";
        string femaleMILF = "Ms.";
        string man = "Mr.";
        string boy = "Master";

        if (age < 16 && gender == "m")
        {
            Console.WriteLine(boy);
        }
        else if (age >= 16 && gender == "m")
        {
            Console.WriteLine(man);
        }
        if (age < 16 && gender == "f")
        {
            Console.WriteLine(femaleYoung);
        }
        else if (age >= 16 && gender == "f")
        {
            Console.WriteLine(femaleMILF);
        }
    }
}

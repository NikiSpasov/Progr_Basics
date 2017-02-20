using System;

class Program
{
    static void Main(string[] args)
    {
        var town = Console.ReadLine();
        var sales = double.Parse(Console.ReadLine());
        var comission = 0;
        if (town == "Sofia")
        {
            if (sales >= 0 && sales <= 500)
            {
                comission = 5;
            }
            else if (sales > 500 && sales <= 1000)
            {
                comission = 7;
            }
            else if (sales > 1000 && sales <= 10000)
            {
                comission = 8;
            }
            else if (sales > 10000 )
            {
                comission = 12;
            }
           
        }
        else if (town == "Plovdiv")
        {

        }
        else if (town == "Varna")
        {

        }
        else
        {
            Console.WriteLine("error");
        }

        if (comission == 0)
        {
            Console.WriteLine("Error");
        }

    }
}


using System;

class Program
{
    static void Main()
    {
        double oldPeople = double.Parse(Console.ReadLine());
        double students = double.Parse(Console.ReadLine());
        double nightsInHotel = double.Parse(Console.ReadLine());
        string transport = Console.ReadLine();

        double totalSum = 0;
 

        if (transport == "train")
        {
            totalSum = (nightsInHotel * 82.99) + (oldPeople * (24.99 * 2) + (students * (14.99 * 2)));
            if (oldPeople + students > 49)
            {
                totalSum = (nightsInHotel * 82.99) + (oldPeople * 24.99 + students * 14.99);
            }
        }
        else if (transport == "bus")
        {
            totalSum = (nightsInHotel * 82.99) + (oldPeople * (32.50 * 2) + (students * (28.50 * 2)));
        }
        else if (transport == "boat")
        {
            totalSum = (nightsInHotel * 82.99) + (oldPeople * (42.99 * 2) + (students * (39.99 * 2)));
        }
        else if (transport == "airplane")
        {
            totalSum = (nightsInHotel * 82.99) + (oldPeople * (70.00 * 2) + (students * (50.00 * 2)));
        }


        double totalPrice = totalSum + ((totalSum * 10) / 100);


        Console.WriteLine("{0:0.00}", totalPrice);
    }
}




namespace _03.HotelRoom
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double apartPricePerNight = 65;
            double studioPricePerNight = 50;

            if (month == "June" || month == "September")
            {
                apartPricePerNight = 68.7;
                studioPricePerNight = 75.2;
            }
            else if (month == "July" || month == "August")
            {
                apartPricePerNight = 77;
                studioPricePerNight = 76;
            }

            double studioPrice = studioPricePerNight * days;
            double apartPrice = apartPricePerNight * days;

            if ((month == "May" || month == "Ocotber") && days > 7 && days < 14)
            {
                studioPrice = studioPrice * 0.95;

            }
            else if (month == "May" || month == "October")
            {
                studioPrice = studioPrice * 0.7;

            }
            else if (month == "June" || month == "September")
            {
                studioPrice = studioPrice * 0.8;
            }

            if (days > 14)
            {
                apartPrice *= 0.9;
            }
            Console.WriteLine("Apartment: {0} lv.", apartPrice);
            Console.WriteLine("Stuido: {0:f2}", studioPrice);
        }
    }
}

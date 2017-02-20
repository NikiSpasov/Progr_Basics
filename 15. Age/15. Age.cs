using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        string dayOfbirht = (Console.ReadLine());
        DateTime bday = Convert.ToDateTime(dayOfbirht);
        DateTime today = DateTime.Today;
        int age = today.Year - bday.Year;
        Console.WriteLine(age);
        Console.WriteLine(age + 10);

        //DateTime now = DateTime.Today;
        //int age = now.Year - bday.Year;
        //if (bday > now.AddYears(-age)) age--;

        //DateTime dt = DateTime.ParseExact(date.ToString(), "MM/DD/YYYY", CultureInfo.InvariantCulture);

        //string s = dt.ToString("dd/M/yyyy", CultureInfo.InvariantCulture);
        //Console.WriteLine("Year: {0}, Month: {1}, Day: {2}", dt.Year, dt.Month, dt.Day);
    }
}
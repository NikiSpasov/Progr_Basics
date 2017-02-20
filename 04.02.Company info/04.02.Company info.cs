using System;

class Program
{
    static void Main(string[] args)
    {
        string company = Console.ReadLine();
        string address = Console.ReadLine();
        string gsm = Console.ReadLine();
        string fax = Console.ReadLine();
        string site = Console.ReadLine();
        string firstNme = Console.ReadLine();
        string lastName = Console.ReadLine();
        string age = Console.ReadLine();
        string phone = Console.ReadLine();

        Console.WriteLine(company);
        Console.WriteLine("Address: " + address);
        Console.WriteLine("Tel. " + gsm);
        if (fax == null || fax == "")
        {
            Console.WriteLine("Fax: (no fax)");
        }
        else
        {
            Console.WriteLine("Fax: {0}", fax);
        }
        Console.WriteLine("Web site: " + site);
        Console.WriteLine("Manager: " 
            + firstNme 
            + " " + lastName 
            + " (age: " 
            + age
            + ", tel. " 
            + phone + ")");
    }
}

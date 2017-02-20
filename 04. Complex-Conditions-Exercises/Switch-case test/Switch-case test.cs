using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        string myName = Console.ReadLine();
 
        switch (myName)
        {
            case "Pesho": Console.WriteLine("Towa e Pesho We"); break; 
          
            case "Nikolay": 
            Console.WriteLine("The best!"); break;
            case "Gosho": Console.WriteLine("Gosho e pendel"); break;
            default:
            Console.WriteLine("Za tebe vdigam vertoletaaaa"); break;

        }
    }
}

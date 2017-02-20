using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TestTest
{
    static void Main()
    {

        var product = Console.ReadLine().ToLower();
        var city = Console.ReadLine().ToLower();
        var quantity = double.Parse(Console.ReadLine());

        if (product == "beer")
        {
            if (city == "Sofia")
            {
                Console.WriteLine(quantity * 1.2);
            }
        }
    }
}
    
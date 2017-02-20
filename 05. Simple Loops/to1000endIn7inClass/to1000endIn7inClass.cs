using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        for (int i = 0; i < 1000; i++)
        {
            if ((i + 1) % 10 == 7)
            {
                Console.WriteLine(i + 1);
            }
        }
    }
}
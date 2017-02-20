using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._05.Calculate_
{

       class CalculateFaktorial
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double X = double.Parse(Console.ReadLine());
            double rezult = 1.00;
            double FaktSum = 1.00;
            double tempX = 1.00;
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                FaktSum *= i;
                sum = tempX * X;
                tempX = sum;
                rezult += FaktSum / tempX;
                
            }

            Console.WriteLine("{0:0.00000}", rezult);

        }
    }
}

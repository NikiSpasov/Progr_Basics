using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        //a+b = c+d
        for (int firstN = 1; firstN <= 9; firstN++)
        {
            for (int secondN = 0; secondN <= 9; secondN++)
            {
                for (int thirdN = 0; thirdN <= 9; thirdN++)
                {
                    for (int fourthN = 0; fourthN <= 9; fourthN++)
                    {
                        if ((firstN + secondN) == (thirdN + fourthN))
                        {
                            Console.WriteLine("({0}, {1}, {2}, {3})", firstN, secondN, thirdN, fourthN);
                        }
                    }

                }

            }

        }
    }
}


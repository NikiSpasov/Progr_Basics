﻿using System;

class numbers1to100inText
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        if (num == 0)
        {
            Console.WriteLine("zero");
        }

        if (num / 100 == 1)
        {
            Console.Write("one hundred ");
            num = num % 100;
        }
        if (num / 100 == 2)
        {
            Console.Write("two hundred ");
            num = num % 100;
        }
        if (num / 100 == 3)
        {
            Console.Write("three hundred ");
            num = num % 100;
        }
        if (num / 100 == 4)
        {
            Console.Write("four hundred ");
            num = num % 100;
        }
        if (num / 100 == 5)
        {
            Console.Write("five hundred ");
            num = num % 100;
        }
        if (num / 100 == 6)
        {
            Console.Write("six hundred ");
            num = num % 100;
        }
        if (num / 100 == 7)
        {
            Console.Write("seven hundred ");
            num = num % 100;
        }
        if (num / 100 == 8)
        {
            Console.Write("eight hundred ");
            num = num % 100;
        }
        if (num / 100 == 9)
        {
            Console.Write("nine hundred ");
            num = num % 100;
        }

        switch (num)
        {

            case 0:
                Console.WriteLine(); break;
            case 1:
                Console.WriteLine("one"); break;
            case 2:
                Console.WriteLine("two"); break;
            case 3:
                Console.WriteLine("three"); break;
            case 4:
                Console.WriteLine("four"); break;
            case 5:
                Console.WriteLine("five"); break;
            case 6:
                Console.WriteLine("six"); break;
            case 7:
                Console.WriteLine("seven"); break;
            case 8:
                Console.WriteLine("eight"); break;
            case 9:
                Console.WriteLine("nine"); break;
            case 10:
                Console.WriteLine("ten"); break;
            case 11:
                Console.WriteLine("eleven"); break;
            case 12:
                Console.WriteLine("twelve"); break;
            case 13:
                Console.WriteLine("thirteen"); break;
            case 14:
                Console.WriteLine("fourteen"); break;
            case 15:
                Console.WriteLine("fifteen"); break;
            case 16:
                Console.WriteLine("sixteen"); break;
            case 17:
                Console.WriteLine("seventeen"); break;
            case 18:
                Console.WriteLine("eighteen"); break;
            case 19:
                Console.WriteLine("nineteen"); break;
        }
        if (num % 100 <= 19)
        {
            return;
        }

        if (num / 10 == 2)
        {
            Console.Write("twenty");
        }
        if (num / 10 == 3)
        {
            Console.Write("thirty");
        }
        if (num / 10 == 4)
        {
            Console.Write("fourty");
        }
        if (num / 10 == 5)
        {
            Console.Write("fifty");
        }
        if (num / 10 == 6)
        {
            Console.Write("sixty");
        }
        if (num / 10 == 7)
        {
            Console.Write("seventy");
        }
        if (num / 10 == 8)
        {
            Console.Write("eighty");
        }
        if (num / 10 == 9)
        {
            Console.Write("ninety");
        }

        if (num % 10 == 0)
            {
                Console.WriteLine();
            }
            else if (num % 10 == 1)
            {
                Console.WriteLine(" one");     
            }
            else if (num % 10 == 2)
            {
                Console.WriteLine(" two");
            }
            else if (num % 10 == 3)
            {
                Console.WriteLine(" three");
            }
            else if (num % 10 == 4)
            {
                Console.WriteLine(" four");
            }
            else if (num % 10 == 5)
            {
                Console.WriteLine(" five");
            }
            else if (num % 10 == 6)
            {
                Console.WriteLine(" six");
            }
            else if (num % 10 == 7)
            {
                Console.WriteLine(" seven");
            }
            else if (num % 10 == 8)
            {
                Console.WriteLine(" eight");
            }
            else if (num % 10 == 9)
            {
                Console.WriteLine(" nine");
            }
        }
    }
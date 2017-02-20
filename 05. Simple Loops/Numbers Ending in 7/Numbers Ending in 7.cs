using System;

// числа от 1 до 1000, завършващи на 7;

class Program
{
    static void Main()
    {
        for (int i = 1; i < 1000; i++)
        {
            if (i % 10 == 7)
            {
                Console.WriteLine(i);
            }
        }
    }
}

//int i = 1232123;
//int lastdigit = (i % 10);

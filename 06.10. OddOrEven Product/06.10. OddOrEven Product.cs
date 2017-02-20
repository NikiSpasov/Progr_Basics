using System;

class Program
{
    static void Main()
    {
        int evenProduct = 1;
        int oddProduct = 1;
        string readNumbers = Console.ReadLine();
        string[] numbers = readNumbers.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);


        for (int i = 0; i < numbers.Length; i++)
        {
            int number = int.Parse(numbers[i]);
            if (i % 2 == 0)
            {
                evenProduct *= number;
            }
            else
            {
                oddProduct *= number;
            }
        }
        if (evenProduct == oddProduct)
        {
            Console.WriteLine("yes {0}", evenProduct);
        }
        else
        {
            Console.WriteLine("no {0} {1}", evenProduct, oddProduct);
        }
    }
}

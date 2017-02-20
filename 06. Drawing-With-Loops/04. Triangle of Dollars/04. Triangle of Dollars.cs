using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int row = 1; row <= n; row++) 
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write("$ ");
            }
            Console.WriteLine();
        }
    }
}


//завъртете два вложени цикъла: за първия row = 1 … n; за втория col = 1 … row.

//Да се напише програма, която въвежда число n и печата триъгълник от долари 
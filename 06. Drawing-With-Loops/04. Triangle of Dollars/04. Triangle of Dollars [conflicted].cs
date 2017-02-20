using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int row = 1; row <= n; row++) //т.е. при а = 4, този 
                                          //цикъл ще се върти 4 пъти /1-2-3-4/
        {
            for (int col = 1; row <= col; col++)
            {
                Console.Write("$ ");
            }
            Console.WriteLine();
        }
    }
}

          
//завъртете два вложени цикъла: за първия row = 1 … n; за втория col = 1 … row.

//Да се напише програма, която въвежда число n и печата триъгълник от долари 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle10by10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++) // Цикъл за редове
            {
                for (int j = 0; j < n; j++) // Цикъл за стълбове
                {

                    if (i == 0 || i == n - 1)// Ако сме на 1ви или последен ред
                    {
                        if (j == 0 || j == n - 1) // и ако сме на 1ви или последен стълб
                        {
                            Console.Write("+"); // изкарай +
                        }
                        else
                        {
                            Console.Write("-"); // иначе - ( тоест ако сме на 1ви или последен ред, ама не сме в краищата значи - )
                        }
                    }
                    else // иначе ако сме в междинната секция
                    {
                        if (j == 0 || j == n - 1) // и сме на 1ви или последен стълб
                        {
                            Console.Write("|");// изкарай |
                        }
                        else
                        {
                            Console.Write("-"); //иначе -
                        }
                    }

                    if (j < n - 1) // след всеки символ
                    {
                        Console.Write(" ");// изкарвай спейс
                    }
                }
                Console.WriteLine();// след края на реда дай нов ред
            }
        }
    }
}
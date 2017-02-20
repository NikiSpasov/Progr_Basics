using System;

class Program
{
    static void Main()
    {
       var card = Console.ReadLine();
       int i = 2;
       
        switch (card)
        {
            case "2":
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                break;
            case "3":
                for (int j = 1; j < 3; i++, j++)
                {
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                }
                break;
            case "4":
                for (int j = 1; j < 4; i++, j++)
                {
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                }
                break;
            case "5":
                for (int j = 1; j < 5; i++, j++)
                {
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                }
                break;
            case "6":
                for (int j = 1; j < 6; i++, j++)
                {
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                }
                break;
            case "7":
                for (int j = 1; j < 7; i++, j++)
                {
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                }
                break;
            case "8":
                for (int j = 1; j < 8; i++, j++)
                {
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                }
                break;
            case "9":
                for (int j = 1; j < 9; i++, j++)
                {
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                }
                break;
            case "10":
                for (int j = 1; j < 10; i++, j++)
                {
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                }
                break;
            case "J":
                for (int j = 1; j < 10; i++, j++)
                {
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                }
                Console.WriteLine("J of spades, J of clubs, J of hearts, J of diamonds");
                break;
            case "Q":
                for (int j = 1; j < 10; i++, j++)
                {
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                }
                Console.WriteLine("J of spades, J of clubs, J of hearts, J of diamonds");
                Console.WriteLine("Q of spades, Q of clubs, Q of hearts, Q of diamonds");
                break;
            case "K":
                for (int j = 1; j < 10; i++, j++)
                {
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                }
                Console.WriteLine("J of spades, J of clubs, J of hearts, J of diamonds");
                Console.WriteLine("Q of spades, Q of clubs, Q of hearts, Q of diamonds");
                Console.WriteLine("K of spades, K of clubs, K of hearts, K of diamonds");
                break;
            case "A":
                for (int j = 1; j < 10; i++, j++)
                {
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", i);
                }
                Console.WriteLine("J of spades, J of clubs, J of hearts, J of diamonds");
                Console.WriteLine("Q of spades, Q of clubs, Q of hearts, Q of diamonds");
                Console.WriteLine("K of spades, K of clubs, K of hearts, K of diamonds");
                Console.WriteLine("A of spades, A of clubs, A of hearts, A of diamonds");
                break;
        }  
    }
}

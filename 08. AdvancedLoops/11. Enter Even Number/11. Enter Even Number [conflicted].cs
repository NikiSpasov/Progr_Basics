using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter even number: ");
        int a = int.Parse(Console.ReadLine());
        int b = a % 2;
        for (int i = 1; i >= 1; i++)
        {
            Console.Write("Enter even number: ");
            if (b == 0)
            {
                Console.WriteLine("Even number entered: {0}", a);            
            }

           

            else if (b != 0)
            {
                Console.WriteLine("The number is not even.");
            }
        }       
    }
}

//•	В цикъл въвеждайте число и проверявайте дали е четно.При коректно число излезте от цикъла.
//•	С try { … } catch { … } конструкция прихванете грешните числа, които не могат да 
//    се обърнат в int.

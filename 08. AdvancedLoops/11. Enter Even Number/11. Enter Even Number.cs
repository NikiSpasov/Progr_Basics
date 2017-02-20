using System;

class Program
{
    static void Main(string[] args)
    {  
        for (int i = 1; i >= 1; i++)
        {
            Console.Write("Enter even number: ");
            try
            {
                int a = int.Parse(Console.ReadLine());
                if ((a & 1) == 0)
                {
                    Console.WriteLine("Even number entered: {0}",
                    a);
                    return;
                }
                else
                {
                    Console.WriteLine("Ivalid number!");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number!"); 
            }   
        }       
    }
}

//•	В цикъл въвеждайте число и проверявайте дали е четно.При коректно число излезте от цикъла.
//•	С try { … } catch { … } конструкция прихванете грешните числа, които не могат да 
//    се обърнат в int.

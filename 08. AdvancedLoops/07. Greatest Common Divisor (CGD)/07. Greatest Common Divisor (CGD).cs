using System;

class Program
{
    static void Main(string[] args)
    {
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());
        int numDifference = 1;
        //int difference;
        int thirdNum;

        if (firstNum >= secondNum)
        {
            numDifference = firstNum - secondNum;
            //сега трябва да намаляваме firstNum с numDifference докато firstNum == secondNum или 
            //firstNum стане по-малко от secondNum; нова променлива thirdNum = firstNum - numDifference
            do
            {
                thirdNum = firstNum - numDifference;
                
            } while (firstNum == secondNum);

            Console.WriteLine("GCD is {0}", thirdNum);   
        } 
    }
}


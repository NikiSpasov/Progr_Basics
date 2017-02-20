using System;

class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int tempNumber = 1;
        for (int row = 1;  row <= num; row++)
        {
            for (int col = 1; col <= row; col++)
            {
                col = tempNumber; 
                Console.Write(col + " ");
                tempNumber = col + 1;                 
            }
            Console.WriteLine();

        }


        //for (int row = 0; row < num; row++)
        //{
        //    for (int col = 0; col <= row; col++)
        //    {
        //        Console.Write(num + " ");
        //        num++;
        //    }
        //    Console.WriteLine();
        //}
    }
}

//Пирамида от числа
//Напишете програма, която въвежда цяло число n и отпечатва пирамида от числа като в примерите: 

//вход   изход       
//7
//        1
//        2 3
//        4 5 6
//        7		

//10	
//        1
//        2 3
//        4 5 6
//        7 8 9 10		
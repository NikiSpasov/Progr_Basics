//using System;

//class Program
//{
//    static void Main()
//    {

//        int num = int.Parse(Console.ReadLine());
//        for (int row = 0; row < num; row++)
//        {
//            for (int col = 0; col <= row; col++)
//            {
//                Console.Write("$ ");
//            }
//            Console.WriteLine();
//        }
//    }
//}



//Other way!

using System;

class Program
{
    static void Main()
    {
        string dollar = "$";
        int num = int.Parse(Console.ReadLine());
        {
            for (int col = 0; col < num; col++)
            {
                Console.WriteLine(dollar);
                dollar += " $";
            }
           
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        int groupStudent = int.Parse(Console.ReadLine());
        int sCar = 0;
        int sBus = 0;
        int sLittleAutobus = 0;
        int sBigAutobus = 0;
        int sTrain = 0;

        int totalStudents = 0; 



        for (int i = 0; i < groupStudent; i++)
        {
            int studentInGroup = int.Parse(Console.ReadLine());

            totalStudents += studentInGroup;

            if (studentInGroup < 6)
            {
                sCar += studentInGroup;
            }
            else if (studentInGroup > 5 && studentInGroup < 13)
            {
                sBus += studentInGroup;
            }
            else if (studentInGroup > 12 && studentInGroup < 26)
            {
                sLittleAutobus += studentInGroup;
            }
            else if (studentInGroup > 25 && studentInGroup < 41)
            {
                sBigAutobus += studentInGroup;
            }
            else if (studentInGroup > 40)
            {
                sTrain += studentInGroup;
            }
        }
        Console.WriteLine("{0:0.00}%",(double)sCar/totalStudents * 100);
        Console.WriteLine("{0:0.00}%", (double)sBus/totalStudents * 100);
        Console.WriteLine("{0:0.00}%", (double)sLittleAutobus/totalStudents * 100);
        Console.WriteLine("{0:0.00}%", (double)sBigAutobus/totalStudents * 100);
        Console.WriteLine("{0:0.00}%", (double)sTrain/totalStudents * 100);
    }
}


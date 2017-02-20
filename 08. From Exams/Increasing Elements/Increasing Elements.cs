using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int cnt = 0;
        int min = int.MinValue;
        int tempCount = 0;

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());

            if (num > min)
            {
                cnt++;
                min = num;
                if (cnt > tempCount)
                {
                    tempCount = cnt;
                }
            }
            else if (num <= min)
            {
                min = num;
                cnt = 1;
            } 
        }
        Console.WriteLine(tempCount);
    }
}
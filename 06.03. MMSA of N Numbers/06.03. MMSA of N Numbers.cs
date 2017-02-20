using System;
class Program
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        int maxNum = 0;
        int minNum = 0;
        int max = int.MaxValue;
        int min = int.MinValue;
        double sum = 0;
        double average = 0;
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (num > min)
            {
                maxNum = num;
                min = maxNum;
            }
            if (num < max)
            {
                minNum = num;
                max = num;
            }
            sum += num;
          
            average = (sum / n);

        }
        Console.WriteLine("min={0:0.00}", minNum);
        Console.WriteLine("max={0:0.00}", maxNum);
        Console.WriteLine("sum={0:0.00}", sum);
        Console.WriteLine("avg={0:0.00}", average);
    }
}
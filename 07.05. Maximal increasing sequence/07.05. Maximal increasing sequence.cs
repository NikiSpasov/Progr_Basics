using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int cnt = 1;
        int max = 0;
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n - 1; i++)
        {
            if (arr[i + 1] - arr[i] >= 1)
            {
                cnt++;
                if (cnt > max)
                {
                    max = cnt;
                }
            }
            else
            {
                cnt = 1;
            }
        }
        Console.WriteLine(max);
    }
}


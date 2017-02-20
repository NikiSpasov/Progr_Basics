using System;

class HistoGram
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double cnt = 0;
        double cnt1 = 0;
        double cnt2 = 0;
        double cnt3 = 0;
        double cnt4 = 0;

        for (int i = 0; i < n; i++)
        {
            double num = int.Parse(Console.ReadLine());
            if (num < 200)
            {
                cnt++;
            }
            else if (num >= 200 && num < 400)
            {
                cnt1++;
            }
            else if (num >= 400 && num < 600)
            {
                cnt2++;
            }
            else if (num >= 600 && num < 800)
            {
                cnt3++;
            }
            else if (num >= 800 && num <= 1000)
            {
                cnt4++;
            }
        }
        Console.WriteLine("{0:f2}", (cnt / n) * 100);
        Console.WriteLine("{0:f2}", (cnt1 / n) * 100);
        Console.WriteLine("{0:f2}", (cnt2 / n) * 100);
        Console.WriteLine("{0:f2}", (cnt3 / n) * 100);
        Console.WriteLine("{0:f2}", (cnt4 / n) * 100);

    }
}

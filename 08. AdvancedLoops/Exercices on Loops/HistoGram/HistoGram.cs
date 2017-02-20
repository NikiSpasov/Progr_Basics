//Дадени са n цели числа в интервала[1…1000]. От тях някакъв процент p1 са под 200, друг 
//    процент p2 са от 200 до 399, друг процент p3 са от 400 до 599, друг процент p4 са 
//    от 600 до 799 и останалите p5 процента са от 800 нагоре.Да се напише програма, която 
//    изчислява и отпечатва процентите p1, p2, p3, p4 и p5.
//Пример: имаме n = 20 числа: 53, 7, 56, 180, 450, 920, 12, 7, 150, 250, 680, 2, 600, 200,
//    800, 799, 199, 46, 128, 65. 
//    

using System;

class HistoGram
{
    static void Main ()
    {
        int n = int.Parse(Console.ReadLine());
        int cnt = 0;
        int cnt1 = 0;
        int cnt2 = 0;
        int cnt3 = 0;
        int cnt4 = 0;

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (num <200)
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
            else if (num >= 800 && num <=1000)
            {
                cnt4++;
            }
        }
        Console.WriteLine(cnt / n * 100 );
        Console.WriteLine(cnt1 / n * 100);
        Console.WriteLine(cnt2 / n * 100);
        Console.WriteLine(cnt3 / n * 100);
        Console.WriteLine(cnt4 / n * 100);

    }
}

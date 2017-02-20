using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int cnt = 1;
        int cnt1 = 1;
        //ширината е 2 * n + 3

        //горна част
        for (int i = 1; i <= n; i++)
        {
            Console.Write(new string ('*', i));
            Console.Write("\\");
            Console.Write(new string('-', (n * 2) - cnt));
            cnt += 2;
            Console.Write("/");
            Console.WriteLine(new string('*', i));
        }
        //среда:
        for (int i = 0; i < n / 3; i++)
        {
            Console.Write("|");
            Console.Write(new string('*', n / 2 + i));
            Console.Write("\\");
            Console.Write(new string('*', n - (2 *i)));
            Console.Write("/");
            Console.Write(new string('*', n / 2 + i));
            Console.WriteLine("|");
        }
        //до долу:
        for (int i = 1; i <= n; i++)
        {
            Console.Write(new string('-', i));
            Console.Write("\\");
            Console.Write(new string('*', (n * 2) - cnt1));
            cnt1 += 2;
            Console.Write("/");
            Console.WriteLine(new string('-', i));                   
        }

    }
}


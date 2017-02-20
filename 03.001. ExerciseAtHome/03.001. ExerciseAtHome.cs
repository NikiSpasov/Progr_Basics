using System;

class Program
{
    static void Main()
    {
        //int n = 168;
        //Console.WriteLine(Convert.ToString(n, 2));
        //int result = 1 & (n >> 2);
        //Console.WriteLine(Convert.ToString(result, 2));      

        //int a = 5;
        //int b = 6;
        //Console.WriteLine(a); //5
        //Console.WriteLine(b); //6

        //a ^= b;
        //b ^= a;
        //a ^= b;

        //Console.WriteLine(a); //6
        //Console.WriteLine(b); //5
        //Console.WriteLine(~(-16));


        //КАК ДА ВЗЕМЕМ БИТА N-та позиция:
        //int n = 17;
        //int position = int.Parse(Console.ReadLine());
        //Console.WriteLine(Convert.ToString(17, 2));
        //int mask = 1 << position;
        //Console.WriteLine((n & mask) >> position);

        int k = 125;
        Console.WriteLine(Convert.ToString(125, 2));
        int result = k | ~(1 << 4);
        Console.WriteLine(Convert.ToString(result, 2));

    }
}

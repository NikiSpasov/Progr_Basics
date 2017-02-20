using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int thirdBit = (n >> 3) & 1;
        int fourthBit = (n >> 4) & 1;
        int fifthBit = (n >> 5) & 1;

        int twentyFourBit = (n >> 24) & 1;
        int twentyFive = (n >> 25) & 1;
        int twentySix = (n >> 26) & 1;
     
        if (thirdBit != twentyFourBit && thirdBit == 0)
        {
            n = (1 << 3) | n;
            n = ~(1 << 24) & n;
        }
        else if (thirdBit != twentyFourBit && thirdBit == 1)
        {
            n = n & ~(1 << 3);
            n = n | (1 << 24);
        }
        else if (fourthBit != twentyFive && fourthBit == 0)
        {
            n = (1 << 4) | n;
            n = ~(1 << 25) & n;
        }
        else if (fourthBit != twentyFive && fourthBit == 1)
        {
            n = n & ~(1 << 4);
            n = n | (1 << 25);
        }

        else if (fifthBit != twentySix && fifthBit == 0)
        {
            n = (1 << 5) | n;
            n = ~(1 << 26) & n;
        }
        else if (fifthBit != twentySix && fifthBit == 1)
        {
            n = n & ~(1 << 5);
            n = n | (1 << 26);
        }

            Console.WriteLine(n);
    }
}

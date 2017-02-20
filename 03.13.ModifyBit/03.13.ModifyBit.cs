using System;

class  
    Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());
        int bitValue = int.Parse(Console.ReadLine());
        int numAfterMod = 0;

        //Console.WriteLine(Convert.ToString(n, 2).PadLeft(16, '0'));
        int firstPostionBit = (n >> position) & 1;
       // Console.WriteLine(firstPostionBit);


        if (firstPostionBit == bitValue)
        {
            numAfterMod = n;
        }
        else
        {
            numAfterMod = (1 << position) ^ n;
        }

        //Console.WriteLine(Convert.ToString(numAfterMod, 2).PadLeft(16, '0'));

        Console.WriteLine(numAfterMod);
    }
}
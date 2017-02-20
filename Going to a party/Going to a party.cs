using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string inputText = Console.ReadLine();
        char[] chars = inputText.ToCharArray();
        int position = 0;
        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[i] > (char)96 && chars[i] < (char)123)
            {
                position += chars[i] - 96;
            }
            else if (chars[i] > (char)64 && chars[i] < (char)91)
            {
                position -= (chars[i] - 63);
            }
       
            if (chars[i] == 94)
            {
                if (position > chars.Length || position < 1)
                {
                    Console.WriteLine("Djor and Djano are lost at {0}!", position);
                    return;
                }
                else
                {
                    Console.WriteLine("Djor and Djano are at the party at {0}!", position);
                    return;
                }
            }
        }
    }
}
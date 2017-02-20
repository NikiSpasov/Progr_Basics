using System;

class Program
{
    static void Main(string[] args)
    {
        char[] alpha = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

        string readFromConsole = Console.ReadLine();

        char[] word = readFromConsole.ToCharArray();

        for (int i = 0; i < word.Length; i++)
        {
            var numIndexOfAlpha = Array.IndexOf(alpha, word[i]);
            Console.WriteLine(numIndexOfAlpha);
        }
    }
}
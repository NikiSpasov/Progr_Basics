using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merging_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int[] summedArr = new int[n - 1];

            for (int j = 0; j < summedArr.Length; j++)
            {
                summedArr[j] = arr[j] + arr[j + 1];
            }

            string[] merged = new string[arr.Length - 1];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int lastDigit = arr[i] % 10;
                int firstDigit = arr[i + 1] / 10;

                string meR = (lastDigit.ToString() + firstDigit.ToString());
                merged[i] = meR;
            }

            Console.WriteLine(String.Join(" ", merged));
            Console.WriteLine(String.Join(" ", summedArr));
        }
    }
}


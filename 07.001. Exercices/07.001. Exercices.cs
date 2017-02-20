using System;
using System.Linq;
using System.Collections.Generic;

class Program

{
    static void Main()
    {
        //Min,Max, Average, Sum:

        //int n = int.Parse(Console.ReadLine());
        //int[] arr = new int[n];
        //double sum = 0;
        //int maxValue = int.MinValue;
        //int minValue = int.MaxValue;
        //double average = 0;

        //for (int i = 0; i < n; i++)
        //{
        //    arr[i] = int.Parse(Console.ReadLine());

        //    sum += arr[i];
        //    if (arr[i] > maxValue)
        //    {
        //        maxValue = arr[i];
        //    }
        //    if (arr[i] < minValue)
        //    {
        //        minValue = arr[i];
        //    }
        //    average = sum / n;
        //}
        //Console.WriteLine("The sum is {0}, max is {1}, min  is {2}, average is {3:0.00}", sum, maxValue, minValue, average);

        //Reading from an one-row and nte the values in the array:

        //string values = Console.ReadLine();
        //string[] items = values.Split(' ');
        //int[] arr = new int[items.Length];
        //for (int i = 0; i < items.Length; i++)
        //{
        //    arr[i] = int.Parse(items[i]);
        //}

        //или същото в един ред: int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        //var input = Console.ReadLine();
        //string[] items = input.Split(new char[] { ' ', ';', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        //int[] nums = items.Select(int.Parse).ToArray();
        //Console.WriteLine("Sum = {0}", nums.Sum());

        //    int n = int.Parse(Console.ReadLine());
        //    int k = int.Parse(Console.ReadLine());
        //    decimal[] arr = new decimal[n];
        //    arr[0] = 1;
        //    for (int i = 1; i < n; i++)
        //    {
        //        arr[i] = SumNums(arr, i - k, i - 1);
        //    }
        //    Console.WriteLine("Sequence: ");
        //    Console.WriteLine(String.Join(" ", arr));

        //}

        //private static decimal SumNums(
        //    decimal[] arr, int startIndex, int endIndex)
        //{
        //    decimal sum = 0;
        //    for (int i = startIndex; i <= endIndex; i++)
        //    {
        //        if (i >= 0)
        //        {
        //            sum += arr[i];
        //        }       
        //    }
        //    return sum;

        //string[] villages = new string[3];

        //for (int i = 0; i < villages.Length; i++)
        //{
        //    villages[i] = Console.ReadLine();
        //}

        //печата ги всичките:
        //foreach (string sela in villages)
        //{
        //    Console.WriteLine(sela);
        //}

        //печата ги на отделни редове:
        //Console.WriteLine(string.Join("\n",  villages));
        //или разделени със запетая:
        //Console.WriteLine(string.Join(", ",  villages));

        //чете от един ред, разделени със запетая, или тире, или шпация - каквото му зададеш:
        //string readNumbers = Console.ReadLine();
        //string[] numbers = readNumbers.Split(new char[] { ',', ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);


        //обърни масива с един цикъл:
        //int[] arr = { 1, 2, 3, 4, 5, };
        //for (int i = 0; i < arr.Length/2; i++)
        //{
        //    int temp = arr[i];
        //    arr[i] = arr[arr.Length - 1 - i];
        //    arr[arr.Length - 1 - i] = temp;
        //}

        //За тази задача бих ти препоръчал да използаваш това:
        int[] n = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        //    Където:
        //     int[] -означава, че създаваш масив от интове.След това четеш данните от конзалата с Console.ReadLine().
        //     .Split(' ') - разделя прочетените данни, с каквото му кажем.В нашият случай с ' '.
        //     Тъй като Console.ReadLine() връща стринг ни е нужно да превърнем всеки елемент в инт за да влезе в масива и за това използваме - .Select(int.Parse).
        //     И накрая добавяме всеки от получениете елементи към масива чрез.ToArray().
        //     За да можем да го направим трябва след using System; да поставим using System.Linq;.
        //Ако не си работил с масиви може да изглежда малко плашещо, но се свиква много бързо и е много удобно в подобни случай.
        int[] m = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    }
}

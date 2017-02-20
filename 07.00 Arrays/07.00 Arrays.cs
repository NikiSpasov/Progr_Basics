using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        //Обръщане на масив:

        //int[] myArray = {1, 2, 3, 4, 5, 6};
        //int lenght = myArray.Length;
        //int[] reverseArray = new int [lenght];
        //for (int i = 0; i < lenght; i++)
        //{
        //    reverseArray[lenght - 1 - i] = myArray[i];
        //}
        //for (int i = 0; i < lenght; i++)
        //{
        //    Console.WriteLine(myArray[i]);
        //}
        //for (int i = 0; i < reverseArray.Length; i++)
        //{
        //    Console.WriteLine(reverseArray[i]);
        //}


        //"Обхождане" на масив от 'n'  елемента:
        //int n = int.Parse(Console.ReadLine());
        //int[] array = new int[n];
        //for (int i = 0; i < array.Length; i++)
        //{
        //    Console.WriteLine(array[i]);
        //}


        //Проверка за симетрия на масив / с предварителни числа/:

        //int[] arr = { 1, 2, 3, 4, 4, 3, 2, 1 };

        //for (int i = 0; i < (arr.Length + 1) / 2; i++)
        //{
        //    if (arr[i] == arr[arr.Length - 1 - i])
        //    {
        //        continue;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Not simetric array!");
        //        return;
        //    }       
        //}
        //Console.WriteLine("Simetric!");


        //Проверка за симетрия с въвеждане на числа:
        //    Console.WriteLine("Enter possitie integer: ");
        //    int n = int.Parse(Console.ReadLine());
        //    bool simetric = true;
        //    int[] arr = new int[n];
        //    Console.WriteLine("Enter values of the array: ");

        //    for (int i = 0; i < n; i++)
        //    {
        //        int val = int.Parse(Console.ReadLine());

        //            arr[i] = val;
        //    }
        //    for (int i = 0; i < arr.Length / 2; i++)
        //    {
        //        if (arr[i] != arr[arr.Length - 1 - i])
        //        {
        //            simetric = false;
        //            break;
        //        }
        //    }
        //    Console.WriteLine("The array is simetric: {0}", simetric);

        //Отпечатване на конзолата на масив:
        //string[] arrToPrint = { "horse", "chicken", "cow", "elephant", "rhino" };
        //for (int index = 0; index < arrToPrint.Length; index++)
        //{
        //    Console.WriteLine(arrToPrint[index]);
        //}

        //отпечатване само на четните индекси:
        //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //int a = 0;
        //for (int index = 0; index < numbers.Length / 2; index++, a++)
        //{ 
        //    Console.WriteLine(numbers[index + a]);
        //}

        //doubling the numbers in an array:
        //int[] nums = { 1, 2, 3, 4 };
        //for (int i = 0; i < nums.Length; i++)
        //{
        //    nums[i] *= 2;
        //    Console.WriteLine(nums[i]);
        //}
        //string[] empty = new string[6];
        //for (int index = 0; index < empty.Length; index++)
        //{
        //    empty[index] = ("" + index);
        //    Console.WriteLine(empty[index]);
        //}

        //умножение на квадрат на всеки четен елемент по цикъла:
        //int[] powerOfTwo = { 1, 2, 3, 4, 5, 6, 7, 8 };
        //for (int index = 0; index < powerOfTwo.Length; index+=2)
        //{
        //    powerOfTwo[index] *= powerOfTwo[index];
        //    Console.WriteLine(powerOfTwo[index]);
        //}

        //обхождане на цикъла отзад напред:

        //int[] reversed = { 1, 2, 3, 4, 5, 6, 7, 8 };
        //for (int index = reversed.Length - 1; index >= 0; index --)
        //{

        //    Console.WriteLine(reversed[index]);
        //}



        //обхождане на масива с foreach:
        //string[] week = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        //foreach (string day in week)
        //{
        //    Console.WriteLine(day);
        //}


        //двумерни, тримерни и многомерни масиви:
        //int[,] twoDimentionalArray; //двумерен масив;
        //int[,,] threeDimentionalArray; //тримерен масив;

        //int[,] intMatrix = new int[3, 4]; // 3 - брой елементи и всеки от тях има размерност 4.
        //все едно 3 броя редове с 4 броя колони - двумерна матрица (таблица);
        //ако един двумерен масив има 3 елемента с по 4 размера във всеки, то той има точно 4 х 3 (12) елемента в него;

        //int[,] twoRowMatrix = 
        //    { 
        //    { 1, 2, 3, 4 },
        //    { 5, 6, 7, 8 }
        //    };
        //Console.WriteLine(twoRowMatrix[1, 2]); //на втория ред, третата цифра. Можем да заместим 1 с row и 2 с col;
        //извличане на броя на редовете:
        //int rowsNum = twoRowMatrix.GetLength(0);
        //int colsNum= twoRowMatrix.GetLength(1); //тук показва дължината на всеки от редовете;
        //тук горния масив се е инициализирал като int[2,4]
        //за да го отпечатаме:
        //for (int row = 0; row < twoRowMatrix.GetLength(0); row++)
        //{
        //    for (int col = 0; col < twoRowMatrix.GetLength(1); col++)
        //    {
        //        Console.Write(twoRowMatrix[row, col]);
        //    }
        //    Console.WriteLine();
        //}


        //как да прочетем един двумерен масив:
        //int[,] arrTwo =
        //    {
        //    { 1, 2, 3, 4},
        //    { 5, 6, 7, 8},
        //    { 9, 10, 11, 12}
        //    };
        //for (int row = 0; row < arrTwo.GetLength(0); row++)
        //{
        //    for (int col = 0; col < arrTwo.GetLength(1); col++)
        //    {
        //        Console.Write(arrTwo[row, col] + " ");
        //    }
        //    Console.WriteLine();
        //}

        //как да "налеем стойности" на двумерен масив:
        //int[,] arrTwo = new int[3, 4];
        //int x = 0;

        //for (int row = 0; row < arrTwo.GetLength(0); row++)
        //{
        //    for (int col = 0; col < arrTwo.GetLength(1); col++)
        //    {
        //        arrTwo[row, col] = x;
        //        x++;
        //        Console.Write(arrTwo[row, col] + " ");
        //    }
        //    Console.WriteLine();
        //}

        //или:
        //Console.Write("Enter a number for rows: ");
        //int rows = int.Parse(Console.ReadLine());
        //Console.Write("Enter a number for cols: ");
        //int cols = int.Parse(Console.ReadLine());
        //int[,] matrix = new int[rows, cols];

        //for (int row = 0; row < matrix.GetLength(0); row++)
        //{
        //    for (int col = 0; col < matrix.GetLength(1); col++)
        //    {
        //        Console.Write("Enter number for positions in matrix: ");
        //        matrix[row, col] = int.Parse(Console.ReadLine());
        //    }
        //}
        //for (int row = 0; row < matrix.GetLength(0); row++)
        //{
        //    for (int col = 0; col < matrix.GetLength(1); col++)
        //    {
        //        Console.Write(matrix[row, col] + " ");
        //    }
        //    Console.WriteLine();
        //}


        //намиране на най-голям сбор от подматрица с размер 2х2: 
        //int sum = 0;
        //int[,] maPlatform =
        //{
        //    { 1, 3, 5, 7, 4 },
        //    { 1, 2, 4, 18 ,9 },
        //    { 13, 145, 0, 0, 1 },
        //    { 13, 14, 15 ,1, 1 }
        //};
        //for (int row = 0; row < maPlatform.GetLength(0); row++)
        //{
        //    for (int col = 0; col < maPlatform.GetLength(1); col++)
        //    {
        //        Console.Write(maPlatform[row, col] + " ");
        //    }
        //    Console.WriteLine();       
        //}
        //int minValue = int.MinValue;
        //int bestRow = 0;
        //int bestCol = 0;
        //for (int row = 0; row < maPlatform.GetLength(0) - 1; row++)
        //{
        //    for (int col = 0; col < maPlatform.GetLength(1) - 1; col++)
        //    {
        //        sum = maPlatform[row, col] + maPlatform[row + 1, col] + maPlatform[row, col + 1]
        //            + maPlatform[row + 1, col + 1];

        //        if (sum > minValue)
        //        {
        //            minValue = sum;
        //            bestRow = row;
        //            bestCol = col;
        //        }
        //    }
        //}
        //Console.WriteLine("The best matrix 2x2 = ");
        //Console.WriteLine("{0} {1}", maPlatform[bestRow, bestCol], maPlatform[bestRow, bestCol + 1]);
        //Console.WriteLine("{0} {1}", maPlatform[bestRow + 1, bestCol], maPlatform[bestRow + 1, bestCol + 1]);


        //Console.WriteLine("The best value is {0}", minValue);

        //!!! LIST - first, add "System.Collection.Generics"; under System;

        //string[] names = { "pesho", "gosho", "andrei" };
        //List<string> namelist = new List<string>() { "gosho" };
        //namelist.Add("Maria");
        //namelist.Add("Ivan");
        //Console.WriteLine(string.Join("-", namelist));
        //namelist[1] = "koi";
        //namelist.Remove("Tosho"); //маха само Тошо;
        //namelist.RemoveAll("Tosho"); // - маха всички /виж синтаксиса;
        //namelist.RemoveAt(1); //- маха от позиция 1

        //for (int i = 0; i < namelist.Count; i++)
        //{
        //    Console.WriteLine(namelist[i]);
        //}

        //как да копираме масиви /внимание, референтен тип не се копира с размяна на променливите, става с цикъл:

        //int[] someNumbers = { 1, 2, 3, 4, 5, };
        //int[] copyOfsomeNumbers = { 0, 0, 0, 0, 0 };

        //for (int i = 0; i < someNumbers.Length ; i++)
        //{
        //    copyOfsomeNumbers[i] = someNumbers[i];
        //}

        // отпечатване на стрингов масив на различни редове: Console.WriteLine(string.Join("\n", myarrr));
        // отпечатване на стрингов масив на същия ред с шпации:  Console.WriteLine(string.Join(" ", myarrr));
        // Console.WriteLine(string.Join("\n", myarrr));

        // Превръщане на масив от инт в масив от стринг: 
        //int[] someNumbers = { 1, 2, 3, 4, 5 };
        //string[] result = someNumbers.Select(x => x.ToString()).ToArray();
        //Console.WriteLine(string.Join(" ", result));

        //Превръщане на масив от стрингове в масив от интове:
        //string s1 = "1-2-3-4-5-6-7-8-9-10-11-12";
        //int[] ints = s1.Split('-').Select(int.Parse).ToArray(); //със Split избираш какво да вземе за разделител между цифрите в стринга, забележи!
        //Console.WriteLine(string.Join(" ", ints)); //тука ги отпечатваме на един ред.


        //Чете от един ред /и някои превръщания/:
        //int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        //var input = Console.ReadLine();
        //string[] items = input.Split(new char[] { ' ', ';', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        //int[] nums = items.Select(int.Parse).ToArray();
        //Console.WriteLine("Sum = {0}", nums.Sum());

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
        //int[] n = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        //    Където:
        //     int[] -означава, че създаваш масив от интове.След това четеш данните от конзалата с Console.ReadLine().
        //     .Split(' ') - разделя прочетените данни, с каквото му кажем.В нашият случай с ' '.
        //     Тъй като Console.ReadLine() връща стринг ни е нужно да превърнем всеки елемент в инт за да влезе в масива и за това използваме - .Select(int.Parse).
        //     И накрая добавяме всеки от получениете елементи към масива чрез.ToArray().
        //     За да можем да го направим трябва след using System; да поставим using System.Linq;.
        //Ако не си работил с масиви може да изглежда малко плашещо, но се свиква много бързо и е много удобно в подобни случай.
        //int[] m = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


        //int to array of ints:
        //long tempNum = num / 10;
        //int[] digits = tempNum.ToString().ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();



        //Jagged array /sorting nums by devisor/
        //problem: Check a set of numbers and group them 
        //by their remainder when divided by 3 (0, 1 and 2)
        int[] numbers = { 0, 1, 4, 113, 55, 3, 1, 2, 66, 557, 124, 2 };
        int[] sizes = new int[3];
        int[] offsets = new int[3];
        foreach (var number in numbers)
        {
            int remainder = number % 3;
            sizes[remainder]++;
        }
        int[][] numbersByRemainder = new int[3][]
        {
      new int[sizes[0]],
      new int[sizes[1]],
      new int[sizes[2]]
        };
        foreach (var number in numbers)
        {
            int remainder = number % 3;
            int index = offsets[remainder];
            numbersByRemainder[remainder][index] = number;
            offsets[remainder]++;
        }
        // print jagged array
        for (int i = 0; i < numbersByRemainder.Length; i++)
        {
            int[] innerArray = numbersByRemainder[i];
            for (int a = 0; a < innerArray.Length; a++)
            {
                Console.Write(innerArray[a] + " ");
            }
            Console.WriteLine();
        }
    }
}

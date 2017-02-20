using System;

class Program
{
    static void Main()
    {
        var s = Console.ReadLine();
        var sum = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == 'a')
            {
                sum += 1;
            }
        }

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == 'e')
            {
                sum += 2;
            }
        }

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == 'i')
            {
                sum += 3;
            }
        }    

        for (int i = 0; i < s.Length; i++)
        { 
            if (s[i] == 'o')
            {
                sum += 4;
            }
        }

        for (int i = 0; i<s.Length; i++)
        { 
            if (s[i] == 'u')
            {
                sum += 5;
            }
        }
        Console.WriteLine(sum);
    }
}

//•	Прочетете входния текст s.Нулирайте сумата.
//•	Завъртете цикъл от 0 до s.Length-1 (дължината на текста -1).
//•	Проверете всяка буква s[i] дали е гласна и съответно добавете към сумата стойността й.

//Да се напише програма, която въвежда текст(стринг) и изчислява и 
//отпечатва сумата от стойностите на гласните букви според таблицата по-долу:
//буква     a   e   i   o   u
//стойност	1	2	3	4	5
//Примери: 
//вход    изход   коментар
//hello   6	e + o = 2 + 4 = 6

//Дадени са 4 цели числа.Напишете програма, която проверява дали числата могат да се разделят на две
//групи с еднаква сума.
//Вход
// Входът се чете от конзолата и се състои от 4 реда, всеки съдържащ по едно цяло число.
//Изход
// Ако числата могат да се разделят на две групи с еднаква сума:
//o Отпечатайте “Yes” на първия ред.
//o Отпечатайте сумата на всяка група на втория ред.
// Ако числата не могат да се разделят на две групи с еднаква сума, отпечатайте “No” на първия ред.
//Ограничения
// Всички входни числа са цели и в диапазона [1 … 1 0



using System;

class softuniada
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());

        int x = a + b;
        int y = c + d;
        int z = b + d;
        int v = a + c;

        int e = x + c; //za d
        int f = v + d;// za b
        int g = z + c;//za a
        int k = z + a;//za c

        if (x == y)
        {
            Console.WriteLine("Yes");
            Console.WriteLine(x);
        }
        else if (z == v)
        {
            Console.WriteLine("Yes");
            Console.WriteLine(z);
        }
        else if (d == e)
        {
            Console.WriteLine("Yes");
            Console.WriteLine(d);
        }
        else if (b == f)
        {
            Console.WriteLine("Yes");
            Console.WriteLine(f);
        }
        else if (a == g)
        {
            Console.WriteLine("Yes");
            Console.WriteLine(g);
        }
        else if (c == k)
        {
            Console.WriteLine("Yes");
            Console.WriteLine(k);
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
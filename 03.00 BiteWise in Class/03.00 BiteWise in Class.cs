﻿using System;

class Program
{
    static void Main()
    {
        //РАЗМЯНА НА ПРОМЕНЛИВИ*:

        //int a = 5;
        //int b = 6;
        //Console.WriteLine(a); //5
        //Console.WriteLine(b); //6

        //a ^= b;
        //b ^= a;
        //a ^= b;

        //Console.WriteLine(a); //6
        //Console.WriteLine(b); //5

        //*ПРАВИЛО:
        //Console.WriteLine((7 ^ 3) ^ 3); //ще даде 3, 
        //винаги едно число,което е ексорнато с друго, 
        //ако още веднъж се ексорне - дава оригиналното число/.

        //ОБРЪЩАНЕ НА БИТОВЕТЕ:
        //можем да обърнем битовете на едно число като го 
        //ексорнеме с 11111111 /само с единици/:
        //Console.WriteLine(~15);// -16; 
        //обръщаме битовете и се получава
        //с обратен знак СЪЩОТО ЧИСЛО, със стойност минус 1. И ОБРАТНОТО важи!

        //КАК ДА ВЗЕМЕМ БИТА НА ЕДНО ЧИСЛО:
        //bitWise Shift 
        //a<<1 /мести с една позиция на ляво! а<<3 /с 3 позиции и т.н.
        // всеки път като шифтнеш с една позиция на ляво ТО СЕ УМНОЖАВА ПО ДВЕ. 
        //ако се шифтне с 2 позиции - по 4, ако с 3 позиции - по осем и  т.н.

        //УМНОЖЕНИЕ И ДЕЛЕНИЕ С ПОБИТОВО §
        //шифтването на дясно дели числата:
        //Console.WriteLine(28 >> 2); //, дели го два пъти, 28/2 = 14
        //и 14/2 = 7; колкото е отместването, толкова пъти се разделя /целочислено/; 
        //шифтването на ляво ги умножава по същия начин:
        //Console.WriteLine(7 << 2); //28

        //НАМИРАНЕ НА ЧЕТНО И НЕЧЕТНО С ПОБИОВО §
        //побитово & с числото 1 на някое число ако върне 1, значи числото е нечетно, при 0 е четно:
        //Console.WriteLine(23 & 1);//връща 1 - значи е нечетно;
        //Console.WriteLine(24 & 1); // връща 0 - четно е числото;


        //ПРЕВРЪЩАНЕ НА ДЕСЕТИЧНО ЧИСЛО В БИНАРНО:
        //Console.WriteLine(Convert.ToString(17,2));
        
        //КАК ДА ВЗЕМЕМ БИТА N-та позиция:
        //int n = 17;
        //int position = int.Parse(Console.ReadLine());
        //int mask = 1 << position;
        //Console.WriteLine((n & mask) >> 4);
        //или


        //int n = 17;
        //Console.WriteLine((n >> 2) & 1);


        //KАК ДА НАПРАВИМ ЕДИН БИТ на 3-та ПОЗИЦИЯ
        //ДА Е "1" ОТ ЕДНО ЧИСЛО:
        //int k = 64;
        //Console.WriteLine(Convert.ToString(64, 2));
        //int result = k | (1 << 3);
        //Console.WriteLine(Convert.ToString(result, 2));

    }
}
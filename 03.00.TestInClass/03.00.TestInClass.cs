using System;

class Program
{
    static void Main(string[] args)
    {
        //int a = 5;
        //a++;
        //Console.WriteLine((5 * 1.7).GetType());//показва какъв тип данни е това в скобите;

        //Console.WriteLine(13 % 3); //винаги резултата ще е под 3!! ПРАВИЛО

        //Console.WriteLine(Convert.ToString(int.MaxValue, 2)); //показва двоичното число;
        //Console.WriteLine(Convert.ToString(int.MaxValue, 2).PadLeft(32, '0')); //показва го в 32 битово число;


        //int overflowed;
        //checked
        //{
        //    overflowed = int.MaxValue + int.Parse("1"); //избива грешката при старт на програмата и показва реда, където е;
        //}
        ////или

        //int maxA = 1000;
        //int maxB = 344380989;
        //Console.WriteLine(checked(maxA * maxB)); //проверява пак грешката;


        //Console.WriteLine(true ^ false); // ще върне true
        //Console.WriteLine(true ^ true); // дава false;
        //този оператор изисква едно от двете да е вярно! /оператора 'екСор'

        //побитови оператори:
        //прилага се върху числа. 
        //0 е false, 1 е true;
        Console.WriteLine(5 | 15);
        Console.WriteLine(Convert.ToString(16, 2));

        //погледни в гугъл двоично пресмятане;
        Console.WriteLine(Convert.ToInt32("10000010", 2));   //това е 130 :)    


    }

}


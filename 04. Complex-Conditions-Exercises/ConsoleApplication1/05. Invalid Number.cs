using System;

class InvalidNumber
{
    static void Main()
    {
        var number = int.Parse(Console.ReadLine());
        if (number != 0 && number < 100 || number > 200) 
        {
            Console.WriteLine("Invalid");
        }
    }
}

//Дадено число е валидно, ако е в диапазона[100…200] или е 0. Да се напише програма, която въвежда цяло число 
//и печата “invalid” ако въведеното число не е валидно.Примери:
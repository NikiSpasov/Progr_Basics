﻿using System;

namespace _13.Volleyball
{
    class Program
    {
        static void Main()
        {
            var year = Console.ReadLine().ToLower();
            double holiDays = int.Parse(Console.ReadLine());
            double homeTown = int.Parse(Console.ReadLine());
            double volleyInHollydays = holiDays * 2 / 3;
            double result;
            double resultInLeap;

            if (year == "normal")
            {
                result = (((48 - homeTown) * 3 / 4) + (holiDays * 2 / 3) + homeTown);   
                Console.WriteLine(Math.Truncate(result));
            }
            else if (year == "leap")
            {
                result = (((48 - homeTown) * 3 / 4) + (holiDays * 2 / 3) + homeTown);
                resultInLeap = (15 * result / 100) + result;
                Console.WriteLine(Math.Truncate(resultInLeap));
            }
        }
    }
}


//Math.Truncate(result)


//Влади е студент, живее в София и си ходи от време на време до родния град.Той е много запален 
//по волейбола, но е зает през работните дни и играе волейбол само през уикендите и в празничните дни.
//Влади играе в София всяка събота, когато не е на работа и не си пътува до родния град, 
//както и в 2/3 от празничните дни.Той пътува до родния си град h пъти в годината, 
//където играе волейбол със старите си приятели в неделя.
//Влади не е на работа 3/4 от уикендите, в които е в София.
//Отделно, през високосните години Влади играе с 15% повече волейбол от нормалното. 
//Приемаме, че годината има точно 48 уикенда, подходящи за волейбол.
//Напишете програма, която изчислява колко пъти Влади е играл волейбол през годината. 
//Закръглете резултата надолу до най-близкото цяло число (например 2.15  2; 9.95  9).
//Входните данни се четат от конзолата:
//•	Първият ред съдържа думата “leap” (високосна година) или “normal” (невисокосна).
//•	Вторият ред съдържа цялото число p – брой празници в годината(които не са събота и неделя).
//•	Третият ред съдържа цялото число h – брой уикенди, в които Влади си пътува до родния град.

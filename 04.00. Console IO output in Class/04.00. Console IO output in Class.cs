using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._00.Console_IO_output_in_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            //allignemnt
            //Console.WriteLine("{0, 5}", 5); //отмества 5 на дясно, иначе ако е -5 - на ляво. to DO!

            //format numbers:
            //Console.WriteLine("{0:0.00}", 12.435223432); //форматира числото до втория знак и го закръглява;
            //Console.WriteLine("{0:X}", 1234); //дава числото в шестнайсетина бройна система;
            //Console.WriteLine("{0:C}", 1234); //дава го в местната валута;
            //Console.WriteLine(Math.Truncate(12.4567)); //реже до запетаята;
            //Console.WriteLine("{0,4:X}", 1234);//

            //int r = Console.Read();//чете следващия символ;
            //Console.WriteLine(r); //изкарва номера от таблицата ASCII;
            //Console.WriteLine((char)(r));//за да излезне същия символ;

            //ConsoleKeyInfo key = Console.ReadKey();
            //Console.WriteLine(key.Key);
            //Console.WriteLine(key.KeyChar);
            //Console.WriteLine(key.Modifiers);

            //Console.WriteLine();
            //string line = Console.ReadLine();
            //int number;
            //bool f = int.TryParse(line, out number);
            //Console.WriteLine(number);

            //Console.OutputEncoding = Encoding.UTF8; //за кирилица;

            Console.WriteLine("Това е кирилица!");


        }
    }
}

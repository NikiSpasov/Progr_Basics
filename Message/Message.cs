using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Message
{
    class Message
    {
        static void Main(string[] args)
        {

            int startDecodind = int.Parse(Console.ReadLine());
            int endDecodind = int.Parse(Console.ReadLine());
            string[] text = Console.ReadLine().Split(new char[] { ',', '.', '!', ' ', ';', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            while (text != "end")
            {

            }
            for (int i = 1; i < startDecodind - endDecodind; i++)
            {
                if (i % 2 != 0)
                {
                    int h = 0;
                    string sym = text[startDecodind - 1 + h];
                    h += 3;
                }
                else
                {
                    string sym = text[startDecodind];
                }
            }


            Console.WriteLine(string.Join(" ", text));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Print_the_ASCII_Table
{
    class ASCII
    {
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            for (int c = 33; c <= 126; c++)
            {
                Console.Write((char)c);
            }
        }
    }
}

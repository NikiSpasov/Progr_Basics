using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_exercices
{
    class Program
    {
        static void Main()
        {
            DateTime a = DateTime.Now;
            string format = "yyyy dd MM hh:mm:ss"; //определя в какъв формат се пишат датите, има редица варианти 
            //(ММ, DD и тн.
        

            Console.WriteLine((a).ToString(format)); // казва как да се отпечата и връзва с горната команда.
        }
    }
}

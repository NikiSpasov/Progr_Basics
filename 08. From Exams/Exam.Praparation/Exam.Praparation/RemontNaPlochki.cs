using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Praparation
{
    class RemontNaPlochki
    {
        static void Main(string[] args)
        {
            double sidePlayground = double.Parse(Console.ReadLine());
            double tileWidht = int.Parse(Console.ReadLine());
            double tileHight = int.Parse(Console.ReadLine());
            double benchWidht = int.Parse(Console.ReadLine());
            double benchHeight = int.Parse(Console.ReadLine());

            double playgroundArea = sidePlayground * 2;
            double tileArea = tileWidht * tileHight;
            double benchArea = benchHeight * benchWidht;

            double totalGround = playgroundArea - benchArea;
            double tilesCount = totalGround / tileArea;
            double timeForWorka = tilesCount * 0.2;

            Console.WriteLine(totalGround);
            Console.WriteLine(tilesCount * 0.2);
        }
    }
}

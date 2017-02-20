using System;

namespace ConsoleApplication1
{
    using System.Text;

    public class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());

            var result = new StringBuilder();

            //First Line
            result.Append('+');
            result.Append(new string('-', input - 2));
            result.Append('+');
            result.AppendLine();

            //Middle
            for (int i = 0; i < input - 2; i++)
            {
                result.Append('|');
                result.Append(new string('-', input - 2));
                result.Append('|');
                result.AppendLine();
            }

            //Last Line
            result.Append('+');
            result.Append(new string('-', input - 2));
            result.Append('+');
            result.AppendLine();

            Console.WriteLine(result.ToString());
        }
    }
}
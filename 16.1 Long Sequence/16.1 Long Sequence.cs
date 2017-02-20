using System;
class PrintSequence
{
    static void Main()
    {
        for (int i = 2; i <= 1001; i++)
        {
            Console.WriteLine((i % 2 == 0) ? i : -(i));
        }
    }
}

//Conditional Operator
//This operator has higher precedence than the next section and lower precedence than the previous section.NOTE, you can click on the operator to go the
//details page with examples.
// t? x : y   –   if test t is true, then evaluate and return x; otherwise, evaluate and return y.
using System;

namespace MyProject1
{
    public class ReplaceVariables
    {
        public ReplaceVariables(int a, int b)
        {
            Console.WriteLine("a: "+ a+"b: "+b);
            a += b;
            b = a - b;
            a = a - b;
            Console.WriteLine("a: " + a + "b: " + b);
        }
    }
}
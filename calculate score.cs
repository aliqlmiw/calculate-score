using System;
using System.Runtime.CompilerServices;

namespace taklif
{
    class Test
    {
        public static void Main()
        {
            Console.Write("please enter midterm score: ");
            double x = Convert.ToInt32 (Console.ReadLine ());
            Console.Write("please enter final score: ");
            double y = Convert.ToInt32 (Console.ReadLine ());
            Console.WriteLine("score = {0}",calc (x,y));
            if (calc(x, y) >= 10)
            {
                Console.WriteLine("passed");
            }
            else
            { 
                Console.WriteLine("failed");
            }
        }

        private static double calc (double x, double y)
        {
            double result = 0.35 * x + 0.65 * y;
            return result;
        }
    }
}
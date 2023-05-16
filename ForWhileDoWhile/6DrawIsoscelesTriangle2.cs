using System;

namespace BasicCSharp.ForWhileDoWhile
{
    public class DrawIsoscelesTriangle2
    {
        public static void DrawIsoscelesTriangle2Main()
        {
            Console.WriteLine("Input number: ");
            int num = Convert.ToInt16(Console.ReadLine());;
            //
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= num-i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2*i-1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
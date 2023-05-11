using System;

namespace BasicCSharp.ForWhileDoWhile
{
    public class DrawNumberTriangle2
    {
        public static void DrawNumberTriangle2Main()
        {
            Console.Write("Input number: ");
            int num = Convert.ToInt16(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j<=i; j++)
                {
                    Console.Write("{0}",i);
                }
                Console.WriteLine();
            }
        }
    }
}
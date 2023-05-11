using System;

namespace BasicCSharp.ForWhileDoWhile
{
    public class DrawNumberTriangle3
    {
        public static void DrawNumberTriangle3Main()
        {
            int k = 1;
            Console.WriteLine("Input number: ");
            int num = Convert.ToInt16(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j<=i; j++)
                {
                    Console.Write("{0} ",k++);
                }
                Console.WriteLine();
            }
        }
    }
}
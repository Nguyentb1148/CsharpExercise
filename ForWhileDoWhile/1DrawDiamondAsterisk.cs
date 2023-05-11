using System;

namespace BasicCSharp.ForWhileDoWhile
{
    public class DrawDiamondAsterisk
    {
        public static void DrawDiamondAsteriskMain()
        {
            Console.WriteLine("Input number: ");
            int num = Convert.ToInt16(Console.ReadLine());;
            
            for (int i = 0; i <= num; i++)
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
            for (int i = num-1; i >=1; i--)
            {
                for (int j = i; j<=num-1; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <=2*i-1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
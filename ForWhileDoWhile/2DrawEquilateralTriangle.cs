using System;

namespace BasicCSharp.ForWhileDoWhile
{
    public class DrawEquilateralTriangle
    {
        public static void DrawEquilateralTriangleMain()
        {
            Console.WriteLine("Input number: ");
            int num = Convert.ToInt16(Console.ReadLine());;
            
            int index = num;
            for (int i = 1; i <= num; i++)
            {
                for (int j=index;j>=1; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j<=i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                index--;
            }
        }
    }
}
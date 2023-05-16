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
                for (int j=index;j>=1; j--)//Draw space
                {
                    Console.Write(" ");
                }
                for (int j = 1; j<=i; j++)//Draw starts
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                index--;
            }
        }
    }
}
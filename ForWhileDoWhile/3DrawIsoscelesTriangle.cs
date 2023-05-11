using System;

namespace BasicCSharp.ForWhileDoWhile
{
    public class DrawIsoscelesTriangle
    {
        public static void DrawIsoscelesTriangleMain()
        {
            var k = 1;
            Console.WriteLine("Input number: ");
            int num = Convert.ToInt16(Console.ReadLine()); ;
            //
            var index = num;
            for (int i = 1; i <= num; i++)
            {
                for (int j=index;j>=1; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j<=i; j++)
                {
                    Console.Write("{0} ",k++);
                }
                Console.WriteLine();
                index--;
            }
        }
    }
}
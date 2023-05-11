using System;

namespace BasicCSharp.ForWhileDoWhile
{
    public class FindPerfectNumber
    {
        public static void FindPerfectNumberMain()
        {
            int sum ;
            Console.Write(" Input begin number: ");
            int begin = int.Parse(Console.ReadLine());
            Console.Write(" Input end number: ");
            int end = int.Parse(Console.ReadLine());
            Console.Write("The perfect numbers in this given: ");
            for (int i = begin; i < end; i++)
            {
                sum = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i%j==0)
                    {
                        sum += j;
                    }
                }

                if (sum==i&& sum!=0)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
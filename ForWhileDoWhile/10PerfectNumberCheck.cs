using System;

namespace BasicCSharp.ForWhileDoWhile
{
    public class PerfectNumberCheck
    {
        /*
         * Enter two numbers a and b and then find and print the perfect numbers
         * in that range. A perfect number is a number whose sum of its divisors
         * is equal to itself (6 :1 2 3 1+2+3=6 => 6 is a perfect number)
         */
        public static void PerfectNumberCheckMain()
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
                for (int j = 1; j < i; j++)//take numbers one by one from 1 to i
                {
                    if (i%j==0)// if divisible by i, add to sum
                    {
                        sum += j;
                    }
                }

                if (sum==i&& sum!=0)//0 is not a perfect number
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
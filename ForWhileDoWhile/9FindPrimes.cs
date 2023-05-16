using System;

namespace BasicCSharp.ForWhileDoWhile
{
    public class FindPrimes
    {
        /*
         *Enter two numbers a and b and then print the prime numbers in that range.
         */
        public static void FindPrimeMaim()
        {
            Console.Write("Start: ");
            int start = Convert.ToInt16(Console.ReadLine());
            Console.Write("End: ");
            int end = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Prime numbers between {0} and {1}",start,end);
            for (int i= start; i < end; i++)//take the values one by one from a to b
            {
                int  index = 0;//count the number of divisors divisible by i
                for (int j = 1; j <= i; j++)
                {
                    if (i%j==0) //Check if i is prime or not
                    {
                        index++;
                    }
                }
                
                if (index==2)
                {
                    Console.Write(i+" ");
                }
            }
            
        }
    }
}
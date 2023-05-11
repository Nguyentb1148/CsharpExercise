using System;

namespace BasicCSharp.ForWhileDoWhile
{
    public class FindPrimes
    {
        public static void FindPrimeMaim()
        {
            Console.Write("Start: ");
            int start = Convert.ToInt16(Console.ReadLine());
            Console.Write("End: ");
            int end = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Prime numbers between {0} and {1}",start,end);
            for (int i= start; i < end; i++)
            {
                int  index = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i%j==0)
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
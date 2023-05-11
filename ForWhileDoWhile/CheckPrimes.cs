using System;

namespace BasicCSharp.ForWhileDoWhile
{
    public class CheckPrimes
    {
        public static void CheckPrimesMain()
        {
            Console.Write("Input Number: ");
            int num = Convert.ToInt16(Console.ReadLine());
            int index=0;
            for (int i = 1; i <= num; i++)
            {
                if (num%i==0)
                {
                    index++;
                }
            }
            Console.WriteLine(index == 2 ? "{0} is prime" : "{0} isn't prime", num);
        }
    }
}
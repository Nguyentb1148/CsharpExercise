using System;

namespace BasicCSharp.ForWhileDoWhile
{
    public class PerfectNumberCheck
    {
        public static void PerfectNumberCheckMain()
        {
            int sum = 0;
            Console.Write(" Input number: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write($"divisors of {num}: ");
            for (int i=1; i <= num/2; i++)
            {
                if (num%i==0)
                {
                    sum += i;
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Sum of the divisors of the number {0} is: {1} ",num,sum);
            if (num==sum)
            {
                Console.WriteLine ($"{num} is perfect number");
            }
            else
            {
                Console.WriteLine ($"{num} isn't perfect number");
            }
        }
    }
}
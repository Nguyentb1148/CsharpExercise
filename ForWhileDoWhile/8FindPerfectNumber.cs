using System;

namespace BasicCSharp.ForWhileDoWhile
{
    public class FindPerfectNumber
    {
        /*
         * Enter a number and then print to the screen whether the number is a perfect number
         * or not. A perfect number is a number whose sum of its divisors is equal to itself
         * (6 :1 2 3; 1+2+3=6 => 6 is a perfect number)
         */
        public static void FindPerfectNumberMain()
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
            Console.WriteLine(num == sum ? $"{num} is perfect number":$"{num} isn't perfect number");
            // if (num==sum)
            // {
            //     Console.WriteLine ($"{num} is perfect number");
            // }
            // else
            // {
            //     Console.WriteLine ($"{num} isn't perfect number");
            // }
        }
    }
}
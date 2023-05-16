using System;

namespace BasicCSharp.ForWhileDoWhile
{
    //Enter an integer and then print to the screen whether the number is prime or not.
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
                    index++;//A prime number is only divisible by 1 and itself, so if the index is equal to 2, it is a prime number
                }
            }
            Console.WriteLine(index == 2 ? "{0} is prime" : "{0} isn't prime", num);
        }
    }
}
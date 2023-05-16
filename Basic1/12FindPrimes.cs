using System;

namespace BasicCSharp.Basic
{
    public class FindPrimes
    {
        /*
         * Enter an integer and then print to the screen whether the number
         * is prime or not
         */
        public static void FindPrimesMain()
        {
            Console.Write("Nhap n: ");
            int num = int.Parse(Console.ReadLine());
            int index = 2;
            while (index < num)//Run numbers one by one from 1 to num
            {
                bool nguyenTo = true;
                if (num < 2)//prime number condition
                {
                    nguyenTo = false;
                }
                else
                {
                    int i = 2;
                    while (i <= Math.Sqrt(index))//Depending on the case, we give different conditions to run the loop
                    {
                        if (index % i == 0)//If any number is divisible by index between 2 and square of the index, then the number is not prime.
                        {
                            nguyenTo = false;
                            break;
                        }
                        i += 1;
                    }
                }
                if (nguyenTo)
                    Console.Write(index+" ");
                index++;
            }
        }
    }
}
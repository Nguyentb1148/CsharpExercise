using System;

namespace BasicCSharp.Basic
{
    public class SumOfNumber
    {
        //Enter any integer and then print the sum of its digits (1234->1+2+3+4=10)
        public static void SumOfNumberMain()
        {
            int so, sum = 0;
            Console.Write("Nhap so:");
            so = int.Parse(Console.ReadLine());
            int bien = 0;
            while (so > 0) //Use while loop to divide numbers into one by one
            {
                bien = so % 10;// assign the value of the number of units rows to index
                sum += bien;
                so = so / 10;// Divide by 10 to reduce 1 row of units
            }
            Console.WriteLine($"Tong cac chu so: " + sum);
            Console.ReadLine();
        }
    }
}
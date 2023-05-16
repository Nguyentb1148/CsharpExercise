using System;

namespace BasicCSharp.Basic2
{
    public class Sum
    {
        /*
         * Enter any array of numbers, enter 2 numbers a, b
         * and then sum the numbers in the range a, b.
         */
        public static void SumMain()
        {
            int sum = 0;
            Console.Write("Nhap kich thuoc mang: ");
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];
            Console.WriteLine("Nhap phan tu");
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"Nhap phan tu thu{i+1}");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Nhap a:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b:");
            int b = int.Parse(Console.ReadLine());
            for (int i = a-1; i < b; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine($"Tong cac phan tu nam trong[{a},{b}] la:"+sum);
            
            Console.ReadLine();
        }
    }
}
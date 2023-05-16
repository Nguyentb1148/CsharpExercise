using System;
using System.Linq;

namespace BasicCSharp.Basic2
{
    public class MaxMinSum
    {
        public static void MaxMinSumMain()
        {
            int[] nhapsotunhien = { 4,2,5,7,43,4};
            foreach (int i in nhapsotunhien)
            {
              Console.Write(i+" ");   
            }
            Console.WriteLine();
            Console.WriteLine("phan tu lon nhat la:" + nhapsotunhien.Max());
            Console.WriteLine("phan tu nho nhat la:" + nhapsotunhien.Min());
            Console.WriteLine("tong gia tri:" + nhapsotunhien.Sum());
            Console.ReadLine();
        }
    }
}
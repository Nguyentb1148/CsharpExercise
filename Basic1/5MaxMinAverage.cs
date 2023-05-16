using System;

namespace BasicCSharp.Basic
{
    public class MaxMinAverage
    {
        //Enter 3 different integers and print the largest,
        //smallest and average of the numbers on the screen
        public static void MaxMinAverageMain()
        {
            Console.WriteLine("Nhap a:");
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b:");
            var b = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap c:");
            var c = int.Parse(Console.ReadLine());
            Console.WriteLine("So lon nhat trong 3 so la " +Math.Max(Math.Max(b,c),a));
            Console.WriteLine("So nho nhat trong 3 so la " +Math.Min(Math.Min(b, c), a));
            Console.WriteLine("Trung binh tong cua 3 so la " + (a+b+c)/3);
            Console.ReadLine();
        }
    }
}
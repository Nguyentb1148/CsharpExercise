using System;

namespace BasicCSharp.Basic
{
    public class File5
    {
        public static void File5Main()
        {
            int a, b, c;
            Console.WriteLine("Nhap a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap c:");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("So lon nhat trong 3 so la " +Math.Max(Math.Max(b,c),a));
            Console.WriteLine("So nho nhat trong 3 so la " +Math.Min(Math.Min(b, c), a));
            Console.WriteLine("Trung binh tong cua 3 so la " + (a+b+c)/3);
            Console.ReadLine();
        }
    }
}
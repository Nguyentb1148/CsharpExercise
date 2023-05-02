using System;

namespace BasicCSharp.Basic
{
    public class File2
    {
        public static void File2Main()
        {
            int so, sum = 0;
            Console.Write("Nhap so:");
            so = int.Parse(Console.ReadLine());
            int bien = 0;
            while (so > 0)
            {
                bien = so % 10;
                sum += bien;
                so = so / 10;
            }
            Console.WriteLine($"Tong cac chu so: " + sum);
            Console.ReadLine();
        }
    }
}
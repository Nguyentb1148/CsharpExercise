using System;

namespace BasicCSharp.Basic2
{
    public class ReverseArray
    {
        public static void ReverseArrayMain()
        {
            Console.Write("Nhap kich thuoc mang: ");
            int SoLuong = int.Parse(Console.ReadLine());
            string[] mang = new string[SoLuong];
            for (int i = 0; i < SoLuong; i++)
            {
                Console.Write($"Nhap phan tu thu {i+1}: ");
                mang[i] = Console.ReadLine();
                Console.WriteLine();
            }
            Console.WriteLine("Cac phan tu da nhap.");
            for (int i = 0; i < SoLuong; i++)
            {
                Console.Write($"Phan tu thu {i+1}: "+mang[i]);
                Console.WriteLine();
            }
            Console.WriteLine("Dao nguoc mang da nhap.");
            for (int i = SoLuong-1; i >= 0; i--)
            {
                Console.Write($"Phan tu thu {i+1}: " + mang[i]);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
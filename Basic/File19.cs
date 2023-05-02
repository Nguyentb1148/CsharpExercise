using System;

namespace BasicCSharp.Basic
{
    public class File19
    {
        public static void File19Main()
        {
            Console.Write("Nhap kich thuoc mang: ");
            int soLuong = int.Parse(Console.ReadLine());
            int[] MangSo = new int[soLuong];
            Console.WriteLine("Nhap phan tu");
            for (int i = 0; i < soLuong; i++)
            {
                Console.WriteLine($"Nhap phan tu thu {i+1}");
                MangSo[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Mang so truoc khi sap xep");
            for (int i = 0; i < soLuong; i++)
            {
                Console.Write(MangSo[i]+" ");
            }
            for (int i = 0; i < soLuong; i++)
            {
                for (int j = i+1; j < soLuong; j++)
                {
                    if(MangSo[i]>MangSo[j])
                    {
                        int bien;
                        bien = MangSo[i];
                        MangSo[i] = MangSo[j];
                        MangSo[j] = bien;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("sau khi sap xep theo thu tu tang dan");
            for (int i = 0; i < soLuong; i++)
            {
                Console.Write(MangSo[i]+" ");
            }
            for (int i = 0; i < soLuong; i++)
            {
                for (int j = i + 1; j < soLuong; j++)
                {
                    if (MangSo[i] < MangSo[j])
                    {
                        int bien;
                        bien = MangSo[i];
                        MangSo[i] = MangSo[j];
                        MangSo[j] = bien;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("sau khi sap xep theo thu tu giam dan");
            for (int i = 0; i < soLuong; i++)
            {
                Console.Write(MangSo[i] + " ");
            }
            Console.ReadLine(); 
        }
    }
}
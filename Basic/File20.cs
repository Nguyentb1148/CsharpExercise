using System;

namespace BasicCSharp.Basic
{
    public class File20
    {
        public static void File20Main()
        {
            int sum = 0;
            Console.Write("Nhap kich thuoc mang: ");
            int soLuong = int.Parse(Console.ReadLine());
            int[] MangSo = new int[soLuong];
            Console.WriteLine("Nhap phan tu");
            for (int i = 0; i < soLuong; i++)
            {
                Console.WriteLine($"Nhap phan tu thu{i+1}");
                MangSo[i] = int.Parse(Console.ReadLine());
            }
            NhapLai:
            Console.Write("Nhap a:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b:");
            int b = int.Parse(Console.ReadLine());
            if(a<0||b>soLuong||a>b)
            {
                Console.WriteLine("Nhap lai a,b");
                goto NhapLai; //Ko lạm dụng goto
            }
            else
            {
                for (int i = a-1; i < b; i++)
                {
                    
                    sum = sum + MangSo[i];
                }
                Console.WriteLine($"Tong cac phan tu nam trong[{a},{b}] la:"+sum);
            }
            Console.ReadLine();
        }
    }
}
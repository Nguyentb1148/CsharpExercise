using System;

namespace BasicCSharp.Basic
{
    public class File17
    {
        public static void File17Main()
        {
            Console.Write("Nhap chuoi: ");
            string chuoi = Console.ReadLine();
            int dem = 0,lan = -1,bien = -1;
            Console.Write("Nhap chuoi con: ");
            string chuoiCon = Console.ReadLine();
            while (dem != -1)
            {
                dem = chuoi.IndexOf(chuoiCon, bien + 1);
                lan += 1;
                bien = dem;
            }
            Console.Write($"{chuoiCon} da xuat hien:" + lan + " lan.");
            Console.ReadLine();
        }
    }
}
using System;

namespace BasicCSharp.Basic2
{
    public class CountCharacter
    {
        /*
         * Enter the character string and the character string to be counted
         * and print the number of occurrences of the string to be counted
         */
        public static void CountCharacterMain()
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
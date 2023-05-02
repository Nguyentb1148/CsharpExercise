using System;

namespace BasicCSharp.Basic
{
    public class File18
    {
        public static void File18Main()
        {
            int dem=0;
            Console.Write("Nhap chuoi: ");
            string chuoi = Console.ReadLine();
            foreach (char item in chuoi)
            {
                dem += 1;
            }
            Console.WriteLine("Chuoi da nhap co: "+dem);
            Console.ReadLine();
        }
    }
}
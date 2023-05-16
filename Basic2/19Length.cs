using System;

namespace BasicCSharp.Basic2
{
    public class Length
    {
        /*
         * Enter a character string and print the length of the string
         * (Do not use built-in methods)
         */
        public static void LengthMain()
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
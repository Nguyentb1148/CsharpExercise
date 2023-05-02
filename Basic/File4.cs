using System;

namespace BasicCSharp.Basic
{
    public class File4
    {
        public static void File4Main()
        {
            int i;
            Console.WriteLine("Nhap mot so: ");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.WriteLine("So ban nhap la so chan ");
            }
            else
            {
                Console.WriteLine("So ban nhap la so le ");
            }
        }
    }
}
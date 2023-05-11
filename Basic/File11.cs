using System;

namespace BasicCSharp.Basic
{
    public class File11
    {
        public static void File11Main()
        {
            Console.Write("Nhap n: ");
            int num = int.Parse(Console.ReadLine());
            int index = 2;
            while (index < num)
            {
                bool nguyenTo = true;
                if (num < 2)
                {
                    nguyenTo = false;
                }
                else
                {
                    int i = 2;
                    while (i <= Math.Sqrt(index))
                    {
                        if (index % i == 0)
                        {
                            nguyenTo = false;
                            break;
                        }
                        i += 1;
                    }
                }
                if (nguyenTo)
                    Console.Write(index+" ");
                index++;
            }
        }
    }
}
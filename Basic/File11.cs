using System;

namespace BasicCSharp.Basic
{
    public class File11
    {
        public static void File11Main()
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());
            int a = 2;
            while (a < n)
            {
                bool NguyenTo = true;
                if (n < 2)
                {
                    NguyenTo = false;
                }
                else
                {
                    int i = 2;
                    while (i <= Math.Sqrt(a))
                    {
                        if (a % i == 0)
                        {
                            NguyenTo = false;
                            break;
                        }
                        i = i + 1;
                    }
                }
                if (NguyenTo)
                    Console.Write(a+" ");
                a++;
            }
        }
    }
}
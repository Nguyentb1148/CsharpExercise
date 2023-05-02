using System;

namespace BasicCSharp.Basic
{
    public class File7
    {
        public static void File7Main()
        {
            int a, b, chon;
            Console.Write("nhap a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("nhap phep tinh(1:/,2:*,3:+,4:-,5:%): ");
            chon =int.Parse( Console.ReadLine());
            switch(chon)
            {
                case 1:
                    Console.Write("Nhap b: ");
                    b = int.Parse(Console.ReadLine());
                    float hieu = a / (float)b;
                    double haiso = Math.Round(hieu, 2);
                    Console.Write($"phep chia cua {a} va {b} la {haiso}");
                    break;
                case 2:
                    Console.Write("Nhap b: ");
                    b = int.Parse(Console.ReadLine());
                    Console.Write($"phep nhan cua {a} va {b} la {a*b}");
                    break;
                case 3:
                    Console.Write("Nhap b: ");
                    b = int.Parse(Console.ReadLine());
                    Console.Write($"phep cong cua {a} va {b} la {a + b}");
                    break;
                case 4:
                    Console.Write("Nhap b: ");
                    b = int.Parse(Console.ReadLine());
                    Console.Write($"phep tru cua {a} va {b} la {a - b}");
                    break;
                case 5:
                    Console.Write("Nhap b: ");
                    b = int.Parse(Console.ReadLine());
                    Console.Write($"phep chia lay du cua {a} va {b} la {a % b}");
                    break;
            }
            Console.ReadLine();
        }
    }
}
using System;

namespace BasicCSharp.Basic
{
    public class File10
    {
        public static void File10Main()
        {
            bool chon = false;
            do
            {
                int a, b;
                Console.Write("Nhap a: ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Nhap b: ");
                b = int.Parse(Console.ReadLine());
                if (a == 0 && b == 0)
                {
                    Console.WriteLine("Khong co UCNN,BCLN");
                }
                else if (a == 0 || b == 0)
                {
                    Console.WriteLine("Khong co BCLN");
                    if (a == 0)
                    {
                        Console.WriteLine($"BCNN cua{a} va {b} la" + b);
                    }
                    else
                    {
                        Console.WriteLine($"BCNN cua{a} va {b} la" + a);
                    }
                }
                else
                {
                    int uCLN = 1;
                    for(int i = 1; i <= a && i < b; i++)
                    {
                        if(a % i == 0 && b % i == 0)
                        {
                            uCLN = i;
                        }
                    }
                    Console.WriteLine("UCLN cua {a} va {b} la: " + uCLN);
                    Console.WriteLine("BCNN cua {a} va {b} la: " + (a*b) / uCLN);
                }
                Console.Write("Nhap true de quay lai:");
                chon = Boolean.Parse(Console.ReadLine());
            } while (chon == true);
            Console.ReadLine();
        }
    }
}